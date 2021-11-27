
library SpawnTentacle2 initializer OnInit requires T32

    globals
        private constant integer UNIT_ID2 = 'U01Z'
        private constant integer TENTACLE_COUNT_BASE = 6
        private constant integer TENTACLE2_ID = 'n098'
        private constant real RADIUS_OFFSET = 250.  //How far away from the caster to position the Tentacles
    endglobals    

    struct tentacleAppendageSet2
        readonly static Table tentacleSetsByCasterHandleId
        readonly unit caster = null
        readonly unit array TentaclesByIndex[30]
        readonly integer TentacleCount = 0
        private integer tick = 0

        method destroy takes nothing returns nothing
            set thistype.tentacleSetsByCasterHandleId[GetHandleId(this.caster)] = 0
            call this.stopPeriodic()
            call this.kill()
            call this.deallocate()
        endmethod

        method kill takes nothing returns nothing
            local integer i = 0
            loop
            exitwhen i > this.TentacleCount
                call KillUnit(this.TentaclesByIndex[i])
                set this.TentaclesByIndex[i] = null
                set i = i + 1
            endloop
        endmethod

        method spawnTentacle takes real x, real y, integer index returns nothing
            local unit tempUnit = CreateUnit(GetOwningPlayer(this.caster), TENTACLE2_ID, x, y, 0)
            call SetUnitAnimation(tempUnit, "birth")
            call QueueUnitAnimation(tempUnit, "stand")
            call SetUnitVertexColor(tempUnit, 255, 255, 255, 255)
            call UnitAddAbility(tempUnit, 'Aloc')
            call SetUnitPathing(tempUnit, false)
            set this.TentaclesByIndex[index] = tempUnit
        endmethod

        method reposition takes nothing returns nothing
            local integer i = 0
            local real offsetAngle = 0
            local real offsetX = 0
            local real offsetY = 0
            set this.TentacleCount = TENTACLE_COUNT_BASE
            loop
            exitwhen i == this.TentacleCount
                set offsetAngle = ((bj_PI*2)/this.TentacleCount)*i
                set offsetX = GetUnitX(caster) + RADIUS_OFFSET*Cos(offsetAngle)
                set offsetY = GetUnitY(caster) + RADIUS_OFFSET*Sin(offsetAngle)
                if GetDistanceBetweenPoints(GetUnitX(this.TentaclesByIndex[i]), GetUnitY(this.TentaclesByIndex[i]), offsetX, offsetY) > 0 then
                    if this.TentaclesByIndex[i] != null then
                        call SetUnitPosition(this.TentaclesByIndex[i], offsetX, offsetY)
                    else
                        call this.spawnTentacle(offsetX, offsetY, i)
                    endif
                endif
                set i = i + 1
            endloop            
        endmethod

        method periodic takes nothing returns nothing
            if this.caster == null then
                call this.destroy()
                return
            endif
            if not IsUnitAliveBJ(this.caster) then
                call this.kill()
                return
            endif
            call this.reposition()
            set this.tick = this.tick + 1
            if this.tick/T32_FPS == 1 then
                set this.tick = 0
            endif
        endmethod

        implement T32x

        static method onInit takes nothing returns nothing
            set thistype.tentacleSetsByCasterHandleId = Table.create()
        endmethod

        static method create takes unit caster returns thistype
            local thistype this = thistype.allocate()
            set this.caster = caster
            set thistype.tentacleSetsByCasterHandleId[GetHandleId(this.caster)] = this
            call this.startPeriodic()
            return this
        endmethod
    endstruct

    private function Built takes nothing returns nothing
        local tentacleAppendageSet2 temptentacleAppendageSet2 = 0
        local unit triggerUnit = null
        local integer triggerUnitHandleId = 0
        set triggerUnit = gg_unit_U01Z_1237
        set triggerUnitHandleId = UNIT_ID2
        set temptentacleAppendageSet2 = tentacleAppendageSet2.tentacleSetsByCasterHandleId[triggerUnitHandleId]
        if temptentacleAppendageSet2 == 0 then
            set temptentacleAppendageSet2 = tentacleAppendageSet2.create(triggerUnit)
            set tentacleAppendageSet2.tentacleSetsByCasterHandleId[triggerUnitHandleId] = temptentacleAppendageSet2
        endif
        set triggerUnit = null
    endfunction

    private function OnInit takes nothing returns nothing
        local trigger trig = CreateTrigger()
        call TriggerRegisterEnterRectSimple( trig, gg_rct_NzothIni)
        call TriggerAddCondition( trig, Condition(function Built))
    endfunction 

endlibrary