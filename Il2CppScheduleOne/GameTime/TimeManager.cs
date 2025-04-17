using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;

namespace Il2CppScheduleOne.GameTime
{
	// Token: 0x02000194 RID: 404
	public class TimeManager : NetworkSingleton<TimeManager>
	{
		// Token: 0x060020C6 RID: 8390 RVA: 0x000D667C File Offset: 0x000D487C
		// Note: this type is marked as 'beforefieldinit'.
		static TimeManager()
		{
			Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.GameTime", "TimeManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr);
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_CYCLE_DURATION_MINS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "CYCLE_DURATION_MINS");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_MINUTE_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "MINUTE_TIME");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_DEFAULT_WAKE_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "DEFAULT_WAKE_TIME");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_END_OF_DAY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "END_OF_DAY");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__SleepInProgress_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "<SleepInProgress>k__BackingField");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__ElapsedDays_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "<ElapsedDays>k__BackingField");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__CurrentTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "<CurrentTime>k__BackingField");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__TimeOnCurrentMinute_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "<TimeOnCurrentMinute>k__BackingField");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_DefaultTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "DefaultTime");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_DefaultDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "DefaultDay");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_TimeProgressionMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "TimeProgressionMultiplier");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__DailyMinTotal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "<DailyMinTotal>k__BackingField");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__Playtime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "<Playtime>k__BackingField");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_savedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "savedTime");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__TimeOverridden_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "<TimeOverridden>k__BackingField");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onMinutePass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "onMinutePass");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onHourPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "onHourPass");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onDayPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "onDayPass");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onWeekPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "onWeekPass");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "onUpdate");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onFixedUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "onFixedUpdate");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onTimeSkip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "onTimeSkip");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "onTick");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onSleepStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "onSleepStart");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__onSleepStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "_onSleepStart");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onSleepEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "onSleepEnd");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__onSleepEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "_onSleepEnd");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onFirstNight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "onFirstNight");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onTimeChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "onTimeChanged");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_SelectedWakeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "SelectedWakeTime");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_sleepStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "sleepStartTime");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_sleepEndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "sleepEndTime");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__HostDailySummaryDone_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "<HostDailySummaryDone>k__BackingField");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_defaultFixedTimeScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "defaultFixedTimeScale");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_loader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "loader");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "<HasChanged>k__BackingField");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.GameTime.TimeManagerAssembly-CSharp.dll_Excuted");
			Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.GameTime.TimeManagerAssembly-CSharp.dll_Excuted");
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_IsEndOfDay_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666954);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_SleepInProgress_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666955);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_SleepInProgress_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666956);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_ElapsedDays_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666957);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_ElapsedDays_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666958);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_CurrentTime_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666959);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_CurrentTime_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666960);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_TimeOnCurrentMinute_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666961);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_TimeOnCurrentMinute_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666962);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_DailyMinTotal_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666963);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_DailyMinTotal_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666964);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_IsNight_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666965);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_DayIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666966);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_NormalizedTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666967);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_Playtime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666968);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_Playtime_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666969);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_CurrentDay_Public_get_EDay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666970);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_TimeOverridden_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666971);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_TimeOverridden_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666972);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_HostDailySummaryDone_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666973);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_HostDailySummaryDone_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666974);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666975);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666976);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666977);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666978);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666979);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666980);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666981);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666982);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666983);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666984);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666985);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666986);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666987);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666988);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_Clean_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666989);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SendTimeData_Public_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666990);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SetData_Private_Void_NetworkConnection_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666991);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666992);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666993);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_ResetHostSleepDone_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666994);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_MarkHostSleepDone_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666995);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SetHostSleepDone_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666996);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_TickLoop_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666997);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_TimeLoop_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666998);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_StaggeredMinPass_Private_IEnumerator_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100666999);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_Tick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667000);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SetTime_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667001);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SetElapsedDays_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667002);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_Get12HourTime_Public_Static_String_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667003);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_Get24HourTimeFromMinSum_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667004);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_GetMinSumFrom24HourTime_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667005);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_IsCurrentTimeWithinRange_Public_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667006);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_IsGivenTimeWithinRange_Public_Static_Boolean_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667007);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_IsValid24HourTime_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667008);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_IsCurrentDateWithinRange_Public_Boolean_GameDateTime_GameDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667009);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_InvokeDayPassClientSide_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667010);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_InvokeWeekPassClientSide_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667011);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_FastForwardToWakeTime_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667012);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_GetDateTime_Public_GameDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667013);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_GetTotalMinSum_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667014);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_AddMinutesTo24HourTime_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667015);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_GetAllTimeInRange_Public_Static_List_1_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667016);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SetWakeTime_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667017);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_StartSleep_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667018);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_EndSleep_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667019);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667020);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SetPlaytime_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667021);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SetTimeOverridden_Public_Void_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667022);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SetRandomTime_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667023);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667024);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr__TimeLoop_b__102_0_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667025);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667026);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667027);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667028);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Observers_SetData_2661156041_Private_Void_NetworkConnection_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667029);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcLogic___SetData_2661156041_Private_Void_NetworkConnection_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667030);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Observers_SetData_2661156041_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667031);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Target_SetData_2661156041_Private_Void_NetworkConnection_Int32_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667032);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Target_SetData_2661156041_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667033);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Server_ResetHostSleepDone_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667034);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcLogic___ResetHostSleepDone_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667035);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Server_ResetHostSleepDone_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667036);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Server_MarkHostSleepDone_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667037);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcLogic___MarkHostSleepDone_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667038);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Server_MarkHostSleepDone_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667039);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Observers_SetHostSleepDone_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667040);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcLogic___SetHostSleepDone_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667041);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Observers_SetHostSleepDone_1140765316_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667042);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Observers_InvokeDayPassClientSide_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667043);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcLogic___InvokeDayPassClientSide_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667044);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Observers_InvokeDayPassClientSide_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667045);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Observers_InvokeWeekPassClientSide_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667046);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcLogic___InvokeWeekPassClientSide_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667047);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Observers_InvokeWeekPassClientSide_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667048);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Server_SetWakeTime_3316948804_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667049);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcLogic___SetWakeTime_3316948804_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667050);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Server_SetWakeTime_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667051);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Observers_StartSleep_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667052);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcLogic___StartSleep_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667053);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Observers_StartSleep_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667054);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Observers_EndSleep_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667055);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcLogic___EndSleep_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667056);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Observers_EndSleep_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667057);
			Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, 100667058);
		}

		// Token: 0x17000B70 RID: 2928
		// (get) Token: 0x060020C7 RID: 8391 RVA: 0x000D7200 File Offset: 0x000D5400
		public unsafe bool IsEndOfDay
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 109308, RefRangeEnd = 109311, XrefRangeStart = 109308, XrefRangeEnd = 109308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_IsEndOfDay_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B71 RID: 2929
		// (get) Token: 0x060020C8 RID: 8392 RVA: 0x000D723C File Offset: 0x000D543C
		// (set) Token: 0x060020C9 RID: 8393 RVA: 0x000D7278 File Offset: 0x000D5478
		public unsafe bool SleepInProgress
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_SleepInProgress_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_SleepInProgress_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000B72 RID: 2930
		// (get) Token: 0x060020CA RID: 8394 RVA: 0x000D72B8 File Offset: 0x000D54B8
		// (set) Token: 0x060020CB RID: 8395 RVA: 0x000D72F4 File Offset: 0x000D54F4
		public unsafe int ElapsedDays
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_ElapsedDays_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_ElapsedDays_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000B73 RID: 2931
		// (get) Token: 0x060020CC RID: 8396 RVA: 0x000D7334 File Offset: 0x000D5534
		// (set) Token: 0x060020CD RID: 8397 RVA: 0x000D7370 File Offset: 0x000D5570
		public unsafe int CurrentTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_CurrentTime_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_CurrentTime_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000B74 RID: 2932
		// (get) Token: 0x060020CE RID: 8398 RVA: 0x000D73B0 File Offset: 0x000D55B0
		// (set) Token: 0x060020CF RID: 8399 RVA: 0x000D73EC File Offset: 0x000D55EC
		public unsafe float TimeOnCurrentMinute
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 59139, RefRangeEnd = 59140, XrefRangeStart = 59139, XrefRangeEnd = 59140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_TimeOnCurrentMinute_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_TimeOnCurrentMinute_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000B75 RID: 2933
		// (get) Token: 0x060020D0 RID: 8400 RVA: 0x000D742C File Offset: 0x000D562C
		// (set) Token: 0x060020D1 RID: 8401 RVA: 0x000D7468 File Offset: 0x000D5668
		public unsafe int DailyMinTotal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_DailyMinTotal_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_DailyMinTotal_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000B76 RID: 2934
		// (get) Token: 0x060020D2 RID: 8402 RVA: 0x000D74A8 File Offset: 0x000D56A8
		public unsafe bool IsNight
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 109311, RefRangeEnd = 109313, XrefRangeStart = 109311, XrefRangeEnd = 109311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_IsNight_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B77 RID: 2935
		// (get) Token: 0x060020D3 RID: 8403 RVA: 0x000D74E4 File Offset: 0x000D56E4
		public unsafe int DayIndex
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 109313, RefRangeEnd = 109319, XrefRangeStart = 109313, XrefRangeEnd = 109313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_DayIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B78 RID: 2936
		// (get) Token: 0x060020D4 RID: 8404 RVA: 0x000D7520 File Offset: 0x000D5720
		public unsafe float NormalizedTime
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 109319, RefRangeEnd = 109320, XrefRangeStart = 109319, XrefRangeEnd = 109319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_NormalizedTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B79 RID: 2937
		// (get) Token: 0x060020D5 RID: 8405 RVA: 0x000D755C File Offset: 0x000D575C
		// (set) Token: 0x060020D6 RID: 8406 RVA: 0x000D7598 File Offset: 0x000D5798
		public unsafe float Playtime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_Playtime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 109320, RefRangeEnd = 109321, XrefRangeStart = 109320, XrefRangeEnd = 109320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_Playtime_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000B7A RID: 2938
		// (get) Token: 0x060020D7 RID: 8407 RVA: 0x000D75D8 File Offset: 0x000D57D8
		public unsafe EDay CurrentDay
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 109313, RefRangeEnd = 109319, XrefRangeStart = 109313, XrefRangeEnd = 109319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_CurrentDay_Public_get_EDay_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B7B RID: 2939
		// (get) Token: 0x060020D8 RID: 8408 RVA: 0x000D7614 File Offset: 0x000D5814
		// (set) Token: 0x060020D9 RID: 8409 RVA: 0x000D7650 File Offset: 0x000D5850
		public unsafe bool TimeOverridden
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_TimeOverridden_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_TimeOverridden_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000B7C RID: 2940
		// (get) Token: 0x060020DA RID: 8410 RVA: 0x000D7690 File Offset: 0x000D5890
		// (set) Token: 0x060020DB RID: 8411 RVA: 0x000D76CC File Offset: 0x000D58CC
		public unsafe bool HostDailySummaryDone
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_HostDailySummaryDone_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_HostDailySummaryDone_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000B7D RID: 2941
		// (get) Token: 0x060020DC RID: 8412 RVA: 0x000D770C File Offset: 0x000D590C
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109321, XrefRangeEnd = 109323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000B7E RID: 2942
		// (get) Token: 0x060020DD RID: 8413 RVA: 0x000D7744 File Offset: 0x000D5944
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109323, XrefRangeEnd = 109325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000B7F RID: 2943
		// (get) Token: 0x060020DE RID: 8414 RVA: 0x000D777C File Offset: 0x000D597C
		public unsafe virtual Loader Loader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr3) : null;
			}
		}

		// Token: 0x17000B80 RID: 2944
		// (get) Token: 0x060020DF RID: 8415 RVA: 0x000D77BC File Offset: 0x000D59BC
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(183)]
			[CachedScanResults(RefRangeStart = 35949, RefRangeEnd = 36132, XrefRangeStart = 35949, XrefRangeEnd = 36132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B81 RID: 2945
		// (get) Token: 0x060020E0 RID: 8416 RVA: 0x000D77F8 File Offset: 0x000D59F8
		// (set) Token: 0x060020E1 RID: 8417 RVA: 0x000D7838 File Offset: 0x000D5A38
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109325, XrefRangeEnd = 109326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000B82 RID: 2946
		// (get) Token: 0x060020E2 RID: 8418 RVA: 0x000D787C File Offset: 0x000D5A7C
		// (set) Token: 0x060020E3 RID: 8419 RVA: 0x000D78BC File Offset: 0x000D5ABC
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109326, XrefRangeEnd = 109327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000B83 RID: 2947
		// (get) Token: 0x060020E4 RID: 8420 RVA: 0x000D7900 File Offset: 0x000D5B00
		// (set) Token: 0x060020E5 RID: 8421 RVA: 0x000D793C File Offset: 0x000D5B3C
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060020E6 RID: 8422 RVA: 0x000D797C File Offset: 0x000D5B7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109327, XrefRangeEnd = 109328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020E7 RID: 8423 RVA: 0x000D79B8 File Offset: 0x000D5BB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109328, XrefRangeEnd = 109334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020E8 RID: 8424 RVA: 0x000D79F4 File Offset: 0x000D5BF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109334, XrefRangeEnd = 109337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020E9 RID: 8425 RVA: 0x000D7A44 File Offset: 0x000D5C44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109337, XrefRangeEnd = 109350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020EA RID: 8426 RVA: 0x000D7A80 File Offset: 0x000D5C80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109350, XrefRangeEnd = 109367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clean()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_Clean_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020EB RID: 8427 RVA: 0x000D7AB4 File Offset: 0x000D5CB4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 109380, RefRangeEnd = 109382, XrefRangeStart = 109367, XrefRangeEnd = 109380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendTimeData(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SendTimeData_Public_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020EC RID: 8428 RVA: 0x000D7AF8 File Offset: 0x000D5CF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 109432, RefRangeEnd = 109433, XrefRangeStart = 109382, XrefRangeEnd = 109432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetData(NetworkConnection conn, int _elapsedDays, int _time, float sendTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _elapsedDays;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _time;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sendTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SetData_Private_Void_NetworkConnection_Int32_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020ED RID: 8429 RVA: 0x000D7B64 File Offset: 0x000D5D64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109433, XrefRangeEnd = 109505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020EE RID: 8430 RVA: 0x000D7BA0 File Offset: 0x000D5DA0
		[CallerCount(0)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020EF RID: 8431 RVA: 0x000D7BDC File Offset: 0x000D5DDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 109526, RefRangeEnd = 109527, XrefRangeStart = 109505, XrefRangeEnd = 109526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetHostSleepDone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_ResetHostSleepDone_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020F0 RID: 8432 RVA: 0x000D7C10 File Offset: 0x000D5E10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 109548, RefRangeEnd = 109549, XrefRangeStart = 109527, XrefRangeEnd = 109548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkHostSleepDone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_MarkHostSleepDone_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020F1 RID: 8433 RVA: 0x000D7C44 File Offset: 0x000D5E44
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 109571, RefRangeEnd = 109577, XrefRangeStart = 109549, XrefRangeEnd = 109571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHostSleepDone(bool done)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref done;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SetHostSleepDone_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020F2 RID: 8434 RVA: 0x000D7C84 File Offset: 0x000D5E84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109577, XrefRangeEnd = 109582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator TickLoop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_TickLoop_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060020F3 RID: 8435 RVA: 0x000D7CC4 File Offset: 0x000D5EC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109582, XrefRangeEnd = 109587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator TimeLoop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_TimeLoop_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060020F4 RID: 8436 RVA: 0x000D7D04 File Offset: 0x000D5F04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109587, XrefRangeEnd = 109592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator StaggeredMinPass(float staggerTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref staggerTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_StaggeredMinPass_Private_IEnumerator_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060020F5 RID: 8437 RVA: 0x000D7D50 File Offset: 0x000D5F50
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 109639, RefRangeEnd = 109641, XrefRangeStart = 109592, XrefRangeEnd = 109639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Tick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_Tick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020F6 RID: 8438 RVA: 0x000D7D84 File Offset: 0x000D5F84
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 109655, RefRangeEnd = 109661, XrefRangeStart = 109641, XrefRangeEnd = 109655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTime(int _time, bool local = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _time;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref local;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SetTime_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020F7 RID: 8439 RVA: 0x000D7DD0 File Offset: 0x000D5FD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 109674, RefRangeEnd = 109675, XrefRangeStart = 109661, XrefRangeEnd = 109674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetElapsedDays(int days)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref days;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SetElapsedDays_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060020F8 RID: 8440 RVA: 0x000D7E10 File Offset: 0x000D6010
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 109703, RefRangeEnd = 109723, XrefRangeStart = 109675, XrefRangeEnd = 109703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Get12HourTime(float _time, bool appendDesignator = true)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _time;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref appendDesignator;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_Get12HourTime_Public_Static_String_Single_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060020F9 RID: 8441 RVA: 0x000D7E58 File Offset: 0x000D6058
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 109723, RefRangeEnd = 109725, XrefRangeStart = 109723, XrefRangeEnd = 109723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Get24HourTimeFromMinSum(int minSum)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref minSum;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_Get24HourTimeFromMinSum_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020FA RID: 8442 RVA: 0x000D7E98 File Offset: 0x000D6098
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 109725, RefRangeEnd = 109746, XrefRangeStart = 109725, XrefRangeEnd = 109725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetMinSumFrom24HourTime(int _time)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_GetMinSumFrom24HourTime_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020FB RID: 8443 RVA: 0x000D7ED8 File Offset: 0x000D60D8
		[CallerCount(42)]
		[CachedScanResults(RefRangeStart = 109746, RefRangeEnd = 109788, XrefRangeStart = 109746, XrefRangeEnd = 109746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsCurrentTimeWithinRange(int min, int max)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref min;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_IsCurrentTimeWithinRange_Public_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020FC RID: 8444 RVA: 0x000D7F30 File Offset: 0x000D6130
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 109788, RefRangeEnd = 109799, XrefRangeStart = 109788, XrefRangeEnd = 109788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsGivenTimeWithinRange(int givenTime, int min, int max)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref givenTime;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_IsGivenTimeWithinRange_Public_Static_Boolean_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020FD RID: 8445 RVA: 0x000D7F8C File Offset: 0x000D618C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 109805, RefRangeEnd = 109806, XrefRangeStart = 109799, XrefRangeEnd = 109805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValid24HourTime(string input)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_IsValid24HourTime_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020FE RID: 8446 RVA: 0x000D7FD0 File Offset: 0x000D61D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 109806, RefRangeEnd = 109807, XrefRangeStart = 109806, XrefRangeEnd = 109806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsCurrentDateWithinRange(GameDateTime start, GameDateTime end)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_IsCurrentDateWithinRange_Public_Boolean_GameDateTime_GameDateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060020FF RID: 8447 RVA: 0x000D8028 File Offset: 0x000D6228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109807, XrefRangeEnd = 109825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeDayPassClientSide()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_InvokeDayPassClientSide_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002100 RID: 8448 RVA: 0x000D805C File Offset: 0x000D625C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109825, XrefRangeEnd = 109843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeWeekPassClientSide()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_InvokeWeekPassClientSide_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002101 RID: 8449 RVA: 0x000D8090 File Offset: 0x000D6290
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 109919, RefRangeEnd = 109920, XrefRangeStart = 109843, XrefRangeEnd = 109919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FastForwardToWakeTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_FastForwardToWakeTime_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002102 RID: 8450 RVA: 0x000D80C4 File Offset: 0x000D62C4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 109920, RefRangeEnd = 109926, XrefRangeStart = 109920, XrefRangeEnd = 109920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameDateTime GetDateTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_GetDateTime_Public_GameDateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002103 RID: 8451 RVA: 0x000D8100 File Offset: 0x000D6300
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 109926, RefRangeEnd = 109930, XrefRangeStart = 109926, XrefRangeEnd = 109926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTotalMinSum()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_GetTotalMinSum_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002104 RID: 8452 RVA: 0x000D813C File Offset: 0x000D633C
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 109930, RefRangeEnd = 109963, XrefRangeStart = 109930, XrefRangeEnd = 109930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int AddMinutesTo24HourTime(int time, int minsToAdd)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref time;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minsToAdd;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_AddMinutesTo24HourTime_Public_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002105 RID: 8453 RVA: 0x000D8188 File Offset: 0x000D6388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109963, XrefRangeEnd = 109977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<int> GetAllTimeInRange(int min, int max)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref min;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_GetAllTimeInRange_Public_Static_List_1_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
		}

		// Token: 0x06002106 RID: 8454 RVA: 0x000D81D8 File Offset: 0x000D63D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 109997, RefRangeEnd = 109999, XrefRangeStart = 109977, XrefRangeEnd = 109997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetWakeTime(int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SetWakeTime_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002107 RID: 8455 RVA: 0x000D8218 File Offset: 0x000D6418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109999, XrefRangeEnd = 110020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartSleep()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_StartSleep_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002108 RID: 8456 RVA: 0x000D824C File Offset: 0x000D644C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110020, XrefRangeEnd = 110041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndSleep()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_EndSleep_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002109 RID: 8457 RVA: 0x000D8280 File Offset: 0x000D6480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110041, XrefRangeEnd = 110047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600210A RID: 8458 RVA: 0x000D82C4 File Offset: 0x000D64C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 109320, RefRangeEnd = 109321, XrefRangeStart = 109320, XrefRangeEnd = 109321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPlaytime(float time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SetPlaytime_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600210B RID: 8459 RVA: 0x000D8304 File Offset: 0x000D6504
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 110055, RefRangeEnd = 110056, XrefRangeStart = 110047, XrefRangeEnd = 110055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTimeOverridden(bool overridden, int time = 1200)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref overridden;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SetTimeOverridden_Public_Void_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600210C RID: 8460 RVA: 0x000D8350 File Offset: 0x000D6550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110056, XrefRangeEnd = 110058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRandomTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_SetRandomTime_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600210D RID: 8461 RVA: 0x000D8384 File Offset: 0x000D6584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110058, XrefRangeEnd = 110078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600210E RID: 8462 RVA: 0x000D83C0 File Offset: 0x000D65C0
		[CallerCount(0)]
		public unsafe bool _TimeLoop_b__102_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr__TimeLoop_b__102_0_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600210F RID: 8463 RVA: 0x000D83FC File Offset: 0x000D65FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110078, XrefRangeEnd = 110143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002110 RID: 8464 RVA: 0x000D8438 File Offset: 0x000D6638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110143, XrefRangeEnd = 110146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002111 RID: 8465 RVA: 0x000D8474 File Offset: 0x000D6674
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002112 RID: 8466 RVA: 0x000D84B0 File Offset: 0x000D66B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110146, XrefRangeEnd = 110169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetData_2661156041(NetworkConnection conn, int _elapsedDays, int _time, float sendTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _elapsedDays;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _time;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sendTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Observers_SetData_2661156041_Private_Void_NetworkConnection_Int32_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002113 RID: 8467 RVA: 0x000D851C File Offset: 0x000D671C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 110176, RefRangeEnd = 110179, XrefRangeStart = 110169, XrefRangeEnd = 110176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetData_2661156041(NetworkConnection conn, int _elapsedDays, int _time, float sendTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _elapsedDays;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _time;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sendTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcLogic___SetData_2661156041_Private_Void_NetworkConnection_Int32_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002114 RID: 8468 RVA: 0x000D8588 File Offset: 0x000D6788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110179, XrefRangeEnd = 110187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetData_2661156041(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Observers_SetData_2661156041_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002115 RID: 8469 RVA: 0x000D85D8 File Offset: 0x000D67D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110187, XrefRangeEnd = 110201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetData_2661156041(NetworkConnection conn, int _elapsedDays, int _time, float sendTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _elapsedDays;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _time;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sendTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Target_SetData_2661156041_Private_Void_NetworkConnection_Int32_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002116 RID: 8470 RVA: 0x000D8644 File Offset: 0x000D6844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110201, XrefRangeEnd = 110209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetData_2661156041(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Target_SetData_2661156041_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002117 RID: 8471 RVA: 0x000D8694 File Offset: 0x000D6894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110209, XrefRangeEnd = 110227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_ResetHostSleepDone_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Server_ResetHostSleepDone_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002118 RID: 8472 RVA: 0x000D86C8 File Offset: 0x000D68C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110227, XrefRangeEnd = 110228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___ResetHostSleepDone_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcLogic___ResetHostSleepDone_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002119 RID: 8473 RVA: 0x000D86FC File Offset: 0x000D68FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110228, XrefRangeEnd = 110231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_ResetHostSleepDone_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Server_ResetHostSleepDone_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600211A RID: 8474 RVA: 0x000D8760 File Offset: 0x000D6960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110231, XrefRangeEnd = 110249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_MarkHostSleepDone_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Server_MarkHostSleepDone_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600211B RID: 8475 RVA: 0x000D8794 File Offset: 0x000D6994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110249, XrefRangeEnd = 110250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___MarkHostSleepDone_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcLogic___MarkHostSleepDone_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600211C RID: 8476 RVA: 0x000D87C8 File Offset: 0x000D69C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110250, XrefRangeEnd = 110253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_MarkHostSleepDone_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Server_MarkHostSleepDone_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600211D RID: 8477 RVA: 0x000D882C File Offset: 0x000D6A2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110253, XrefRangeEnd = 110272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetHostSleepDone_1140765316(bool done)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref done;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Observers_SetHostSleepDone_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600211E RID: 8478 RVA: 0x000D886C File Offset: 0x000D6A6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 110283, RefRangeEnd = 110285, XrefRangeStart = 110272, XrefRangeEnd = 110283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetHostSleepDone_1140765316(bool done)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref done;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcLogic___SetHostSleepDone_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600211F RID: 8479 RVA: 0x000D88AC File Offset: 0x000D6AAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110285, XrefRangeEnd = 110288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetHostSleepDone_1140765316(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Observers_SetHostSleepDone_1140765316_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002120 RID: 8480 RVA: 0x000D88FC File Offset: 0x000D6AFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_InvokeDayPassClientSide_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Observers_InvokeDayPassClientSide_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002121 RID: 8481 RVA: 0x000D8930 File Offset: 0x000D6B30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110288, XrefRangeEnd = 110289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___InvokeDayPassClientSide_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcLogic___InvokeDayPassClientSide_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002122 RID: 8482 RVA: 0x000D8964 File Offset: 0x000D6B64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110289, XrefRangeEnd = 110291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_InvokeDayPassClientSide_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Observers_InvokeDayPassClientSide_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002123 RID: 8483 RVA: 0x000D89B4 File Offset: 0x000D6BB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_InvokeWeekPassClientSide_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Observers_InvokeWeekPassClientSide_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002124 RID: 8484 RVA: 0x000D89E8 File Offset: 0x000D6BE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110291, XrefRangeEnd = 110292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___InvokeWeekPassClientSide_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcLogic___InvokeWeekPassClientSide_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002125 RID: 8485 RVA: 0x000D8A1C File Offset: 0x000D6C1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110292, XrefRangeEnd = 110294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_InvokeWeekPassClientSide_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Observers_InvokeWeekPassClientSide_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002126 RID: 8486 RVA: 0x000D8A6C File Offset: 0x000D6C6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 109997, RefRangeEnd = 109999, XrefRangeStart = 109997, XrefRangeEnd = 109999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetWakeTime_3316948804(int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Server_SetWakeTime_3316948804_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002127 RID: 8487 RVA: 0x000D8AAC File Offset: 0x000D6CAC
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetWakeTime_3316948804(int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcLogic___SetWakeTime_3316948804_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002128 RID: 8488 RVA: 0x000D8AEC File Offset: 0x000D6CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110294, XrefRangeEnd = 110298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetWakeTime_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Server_SetWakeTime_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002129 RID: 8489 RVA: 0x000D8B50 File Offset: 0x000D6D50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110298, XrefRangeEnd = 110316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_StartSleep_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Observers_StartSleep_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600212A RID: 8490 RVA: 0x000D8B84 File Offset: 0x000D6D84
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 110331, RefRangeEnd = 110336, XrefRangeStart = 110316, XrefRangeEnd = 110331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___StartSleep_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcLogic___StartSleep_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600212B RID: 8491 RVA: 0x000D8BB8 File Offset: 0x000D6DB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110336, XrefRangeEnd = 110339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_StartSleep_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Observers_StartSleep_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600212C RID: 8492 RVA: 0x000D8C08 File Offset: 0x000D6E08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110339, XrefRangeEnd = 110357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_EndSleep_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcWriter___Observers_EndSleep_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600212D RID: 8493 RVA: 0x000D8C3C File Offset: 0x000D6E3C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 110388, RefRangeEnd = 110391, XrefRangeStart = 110357, XrefRangeEnd = 110388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___EndSleep_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcLogic___EndSleep_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600212E RID: 8494 RVA: 0x000D8C70 File Offset: 0x000D6E70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 110391, XrefRangeEnd = 110394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_EndSleep_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_RpcReader___Observers_EndSleep_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600212F RID: 8495 RVA: 0x000D8CC0 File Offset: 0x000D6EC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 110442, RefRangeEnd = 110443, XrefRangeStart = 110394, XrefRangeEnd = 110442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Il2CppScheduleOne.GameTime.TimeManager.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002130 RID: 8496 RVA: 0x00012700 File Offset: 0x00010900
		public TimeManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000B48 RID: 2888
		// (get) Token: 0x06002131 RID: 8497 RVA: 0x000D8CFC File Offset: 0x000D6EFC
		// (set) Token: 0x06002132 RID: 8498 RVA: 0x00012709 File Offset: 0x00010909
		public unsafe static float CYCLE_DURATION_MINS
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_CYCLE_DURATION_MINS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_CYCLE_DURATION_MINS, (void*)(&value));
			}
		}

		// Token: 0x17000B49 RID: 2889
		// (get) Token: 0x06002133 RID: 8499 RVA: 0x000D8D18 File Offset: 0x000D6F18
		// (set) Token: 0x06002134 RID: 8500 RVA: 0x00012717 File Offset: 0x00010917
		public unsafe static float MINUTE_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_MINUTE_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_MINUTE_TIME, (void*)(&value));
			}
		}

		// Token: 0x17000B4A RID: 2890
		// (get) Token: 0x06002135 RID: 8501 RVA: 0x000D8D34 File Offset: 0x000D6F34
		// (set) Token: 0x06002136 RID: 8502 RVA: 0x00012725 File Offset: 0x00010925
		public unsafe static int DEFAULT_WAKE_TIME
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_DEFAULT_WAKE_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_DEFAULT_WAKE_TIME, (void*)(&value));
			}
		}

		// Token: 0x17000B4B RID: 2891
		// (get) Token: 0x06002137 RID: 8503 RVA: 0x000D8D50 File Offset: 0x000D6F50
		// (set) Token: 0x06002138 RID: 8504 RVA: 0x00012733 File Offset: 0x00010933
		public unsafe static int END_OF_DAY
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_END_OF_DAY, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_END_OF_DAY, (void*)(&value));
			}
		}

		// Token: 0x17000B4C RID: 2892
		// (get) Token: 0x06002139 RID: 8505 RVA: 0x000D8D6C File Offset: 0x000D6F6C
		// (set) Token: 0x0600213A RID: 8506 RVA: 0x00012741 File Offset: 0x00010941
		public unsafe bool _SleepInProgress_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__SleepInProgress_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__SleepInProgress_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B4D RID: 2893
		// (get) Token: 0x0600213B RID: 8507 RVA: 0x000D8D94 File Offset: 0x000D6F94
		// (set) Token: 0x0600213C RID: 8508 RVA: 0x0001275C File Offset: 0x0001095C
		public unsafe int _ElapsedDays_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__ElapsedDays_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__ElapsedDays_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B4E RID: 2894
		// (get) Token: 0x0600213D RID: 8509 RVA: 0x000D8DBC File Offset: 0x000D6FBC
		// (set) Token: 0x0600213E RID: 8510 RVA: 0x00012777 File Offset: 0x00010977
		public unsafe int _CurrentTime_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__CurrentTime_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__CurrentTime_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B4F RID: 2895
		// (get) Token: 0x0600213F RID: 8511 RVA: 0x000D8DE4 File Offset: 0x000D6FE4
		// (set) Token: 0x06002140 RID: 8512 RVA: 0x00012792 File Offset: 0x00010992
		public unsafe float _TimeOnCurrentMinute_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__TimeOnCurrentMinute_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__TimeOnCurrentMinute_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B50 RID: 2896
		// (get) Token: 0x06002141 RID: 8513 RVA: 0x000D8E0C File Offset: 0x000D700C
		// (set) Token: 0x06002142 RID: 8514 RVA: 0x000127AD File Offset: 0x000109AD
		public unsafe int DefaultTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_DefaultTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_DefaultTime)) = value;
			}
		}

		// Token: 0x17000B51 RID: 2897
		// (get) Token: 0x06002143 RID: 8515 RVA: 0x000D8E34 File Offset: 0x000D7034
		// (set) Token: 0x06002144 RID: 8516 RVA: 0x000127C8 File Offset: 0x000109C8
		public unsafe EDay DefaultDay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_DefaultDay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_DefaultDay)) = value;
			}
		}

		// Token: 0x17000B52 RID: 2898
		// (get) Token: 0x06002145 RID: 8517 RVA: 0x000D8E5C File Offset: 0x000D705C
		// (set) Token: 0x06002146 RID: 8518 RVA: 0x000127E3 File Offset: 0x000109E3
		public unsafe float TimeProgressionMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_TimeProgressionMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_TimeProgressionMultiplier)) = value;
			}
		}

		// Token: 0x17000B53 RID: 2899
		// (get) Token: 0x06002147 RID: 8519 RVA: 0x000D8E84 File Offset: 0x000D7084
		// (set) Token: 0x06002148 RID: 8520 RVA: 0x000127FE File Offset: 0x000109FE
		public unsafe int _DailyMinTotal_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__DailyMinTotal_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__DailyMinTotal_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B54 RID: 2900
		// (get) Token: 0x06002149 RID: 8521 RVA: 0x000D8EAC File Offset: 0x000D70AC
		// (set) Token: 0x0600214A RID: 8522 RVA: 0x00012819 File Offset: 0x00010A19
		public unsafe float _Playtime_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__Playtime_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__Playtime_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B55 RID: 2901
		// (get) Token: 0x0600214B RID: 8523 RVA: 0x000D8ED4 File Offset: 0x000D70D4
		// (set) Token: 0x0600214C RID: 8524 RVA: 0x00012834 File Offset: 0x00010A34
		public unsafe int savedTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_savedTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_savedTime)) = value;
			}
		}

		// Token: 0x17000B56 RID: 2902
		// (get) Token: 0x0600214D RID: 8525 RVA: 0x000D8EFC File Offset: 0x000D70FC
		// (set) Token: 0x0600214E RID: 8526 RVA: 0x0001284F File Offset: 0x00010A4F
		public unsafe bool _TimeOverridden_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__TimeOverridden_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__TimeOverridden_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B57 RID: 2903
		// (get) Token: 0x0600214F RID: 8527 RVA: 0x000D8F24 File Offset: 0x000D7124
		// (set) Token: 0x06002150 RID: 8528 RVA: 0x0001286A File Offset: 0x00010A6A
		public unsafe Action onMinutePass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onMinutePass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onMinutePass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B58 RID: 2904
		// (get) Token: 0x06002151 RID: 8529 RVA: 0x000D8F54 File Offset: 0x000D7154
		// (set) Token: 0x06002152 RID: 8530 RVA: 0x00012889 File Offset: 0x00010A89
		public unsafe Action onHourPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onHourPass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onHourPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B59 RID: 2905
		// (get) Token: 0x06002153 RID: 8531 RVA: 0x000D8F84 File Offset: 0x000D7184
		// (set) Token: 0x06002154 RID: 8532 RVA: 0x000128A8 File Offset: 0x00010AA8
		public unsafe Action onDayPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onDayPass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onDayPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B5A RID: 2906
		// (get) Token: 0x06002155 RID: 8533 RVA: 0x000D8FB4 File Offset: 0x000D71B4
		// (set) Token: 0x06002156 RID: 8534 RVA: 0x000128C7 File Offset: 0x00010AC7
		public unsafe Action onWeekPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onWeekPass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onWeekPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B5B RID: 2907
		// (get) Token: 0x06002157 RID: 8535 RVA: 0x000D8FE4 File Offset: 0x000D71E4
		// (set) Token: 0x06002158 RID: 8536 RVA: 0x000128E6 File Offset: 0x00010AE6
		public unsafe Action onUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onUpdate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onUpdate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B5C RID: 2908
		// (get) Token: 0x06002159 RID: 8537 RVA: 0x000D9014 File Offset: 0x000D7214
		// (set) Token: 0x0600215A RID: 8538 RVA: 0x00012905 File Offset: 0x00010B05
		public unsafe Action onFixedUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onFixedUpdate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onFixedUpdate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B5D RID: 2909
		// (get) Token: 0x0600215B RID: 8539 RVA: 0x000D9044 File Offset: 0x000D7244
		// (set) Token: 0x0600215C RID: 8540 RVA: 0x00012924 File Offset: 0x00010B24
		public unsafe Action<int> onTimeSkip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onTimeSkip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onTimeSkip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B5E RID: 2910
		// (get) Token: 0x0600215D RID: 8541 RVA: 0x000D9074 File Offset: 0x000D7274
		// (set) Token: 0x0600215E RID: 8542 RVA: 0x00012943 File Offset: 0x00010B43
		public unsafe Action onTick
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onTick);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onTick), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B5F RID: 2911
		// (get) Token: 0x0600215F RID: 8543 RVA: 0x000D90A4 File Offset: 0x000D72A4
		// (set) Token: 0x06002160 RID: 8544 RVA: 0x00012962 File Offset: 0x00010B62
		public unsafe static Action onSleepStart
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onSleepStart, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onSleepStart, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B60 RID: 2912
		// (get) Token: 0x06002161 RID: 8545 RVA: 0x000D90CC File Offset: 0x000D72CC
		// (set) Token: 0x06002162 RID: 8546 RVA: 0x00012974 File Offset: 0x00010B74
		public unsafe UnityEvent _onSleepStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__onSleepStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__onSleepStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B61 RID: 2913
		// (get) Token: 0x06002163 RID: 8547 RVA: 0x000D90FC File Offset: 0x000D72FC
		// (set) Token: 0x06002164 RID: 8548 RVA: 0x00012993 File Offset: 0x00010B93
		public unsafe static Action<int> onSleepEnd
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onSleepEnd, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onSleepEnd, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B62 RID: 2914
		// (get) Token: 0x06002165 RID: 8549 RVA: 0x000D9124 File Offset: 0x000D7324
		// (set) Token: 0x06002166 RID: 8550 RVA: 0x000129A5 File Offset: 0x00010BA5
		public unsafe UnityEvent _onSleepEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__onSleepEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__onSleepEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B63 RID: 2915
		// (get) Token: 0x06002167 RID: 8551 RVA: 0x000D9154 File Offset: 0x000D7354
		// (set) Token: 0x06002168 RID: 8552 RVA: 0x000129C4 File Offset: 0x00010BC4
		public unsafe UnityEvent onFirstNight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onFirstNight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onFirstNight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B64 RID: 2916
		// (get) Token: 0x06002169 RID: 8553 RVA: 0x000D9184 File Offset: 0x000D7384
		// (set) Token: 0x0600216A RID: 8554 RVA: 0x000129E3 File Offset: 0x00010BE3
		public unsafe Action onTimeChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onTimeChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_onTimeChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B65 RID: 2917
		// (get) Token: 0x0600216B RID: 8555 RVA: 0x000D91B4 File Offset: 0x000D73B4
		// (set) Token: 0x0600216C RID: 8556 RVA: 0x00012A02 File Offset: 0x00010C02
		public unsafe static int SelectedWakeTime
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_SelectedWakeTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_SelectedWakeTime, (void*)(&value));
			}
		}

		// Token: 0x17000B66 RID: 2918
		// (get) Token: 0x0600216D RID: 8557 RVA: 0x000D91D0 File Offset: 0x000D73D0
		// (set) Token: 0x0600216E RID: 8558 RVA: 0x00012A10 File Offset: 0x00010C10
		public unsafe GameDateTime sleepStartTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_sleepStartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_sleepStartTime)) = value;
			}
		}

		// Token: 0x17000B67 RID: 2919
		// (get) Token: 0x0600216F RID: 8559 RVA: 0x000D91F8 File Offset: 0x000D73F8
		// (set) Token: 0x06002170 RID: 8560 RVA: 0x00012A2B File Offset: 0x00010C2B
		public unsafe int sleepEndTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_sleepEndTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_sleepEndTime)) = value;
			}
		}

		// Token: 0x17000B68 RID: 2920
		// (get) Token: 0x06002171 RID: 8561 RVA: 0x000D9220 File Offset: 0x000D7420
		// (set) Token: 0x06002172 RID: 8562 RVA: 0x00012A46 File Offset: 0x00010C46
		public unsafe bool _HostDailySummaryDone_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__HostDailySummaryDone_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__HostDailySummaryDone_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B69 RID: 2921
		// (get) Token: 0x06002173 RID: 8563 RVA: 0x000D9248 File Offset: 0x000D7448
		// (set) Token: 0x06002174 RID: 8564 RVA: 0x00012A61 File Offset: 0x00010C61
		public unsafe float defaultFixedTimeScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_defaultFixedTimeScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_defaultFixedTimeScale)) = value;
			}
		}

		// Token: 0x17000B6A RID: 2922
		// (get) Token: 0x06002175 RID: 8565 RVA: 0x000D9270 File Offset: 0x000D7470
		// (set) Token: 0x06002176 RID: 8566 RVA: 0x00012A7C File Offset: 0x00010C7C
		public unsafe TimeLoader loader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_loader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimeLoader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_loader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B6B RID: 2923
		// (get) Token: 0x06002177 RID: 8567 RVA: 0x000D92A0 File Offset: 0x000D74A0
		// (set) Token: 0x06002178 RID: 8568 RVA: 0x00012A9B File Offset: 0x00010C9B
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B6C RID: 2924
		// (get) Token: 0x06002179 RID: 8569 RVA: 0x000D92D0 File Offset: 0x000D74D0
		// (set) Token: 0x0600217A RID: 8570 RVA: 0x00012ABA File Offset: 0x00010CBA
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B6D RID: 2925
		// (get) Token: 0x0600217B RID: 8571 RVA: 0x000D9300 File Offset: 0x000D7500
		// (set) Token: 0x0600217C RID: 8572 RVA: 0x00012AD9 File Offset: 0x00010CD9
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B6E RID: 2926
		// (get) Token: 0x0600217D RID: 8573 RVA: 0x000D9328 File Offset: 0x000D7528
		// (set) Token: 0x0600217E RID: 8574 RVA: 0x00012AF4 File Offset: 0x00010CF4
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17000B6F RID: 2927
		// (get) Token: 0x0600217F RID: 8575 RVA: 0x000D9350 File Offset: 0x000D7550
		// (set) Token: 0x06002180 RID: 8576 RVA: 0x00012B0F File Offset: 0x00010D0F
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040015C2 RID: 5570
		private static readonly IntPtr NativeFieldInfoPtr_CYCLE_DURATION_MINS;

		// Token: 0x040015C3 RID: 5571
		private static readonly IntPtr NativeFieldInfoPtr_MINUTE_TIME;

		// Token: 0x040015C4 RID: 5572
		private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_WAKE_TIME;

		// Token: 0x040015C5 RID: 5573
		private static readonly IntPtr NativeFieldInfoPtr_END_OF_DAY;

		// Token: 0x040015C6 RID: 5574
		private static readonly IntPtr NativeFieldInfoPtr__SleepInProgress_k__BackingField;

		// Token: 0x040015C7 RID: 5575
		private static readonly IntPtr NativeFieldInfoPtr__ElapsedDays_k__BackingField;

		// Token: 0x040015C8 RID: 5576
		private static readonly IntPtr NativeFieldInfoPtr__CurrentTime_k__BackingField;

		// Token: 0x040015C9 RID: 5577
		private static readonly IntPtr NativeFieldInfoPtr__TimeOnCurrentMinute_k__BackingField;

		// Token: 0x040015CA RID: 5578
		private static readonly IntPtr NativeFieldInfoPtr_DefaultTime;

		// Token: 0x040015CB RID: 5579
		private static readonly IntPtr NativeFieldInfoPtr_DefaultDay;

		// Token: 0x040015CC RID: 5580
		private static readonly IntPtr NativeFieldInfoPtr_TimeProgressionMultiplier;

		// Token: 0x040015CD RID: 5581
		private static readonly IntPtr NativeFieldInfoPtr__DailyMinTotal_k__BackingField;

		// Token: 0x040015CE RID: 5582
		private static readonly IntPtr NativeFieldInfoPtr__Playtime_k__BackingField;

		// Token: 0x040015CF RID: 5583
		private static readonly IntPtr NativeFieldInfoPtr_savedTime;

		// Token: 0x040015D0 RID: 5584
		private static readonly IntPtr NativeFieldInfoPtr__TimeOverridden_k__BackingField;

		// Token: 0x040015D1 RID: 5585
		private static readonly IntPtr NativeFieldInfoPtr_onMinutePass;

		// Token: 0x040015D2 RID: 5586
		private static readonly IntPtr NativeFieldInfoPtr_onHourPass;

		// Token: 0x040015D3 RID: 5587
		private static readonly IntPtr NativeFieldInfoPtr_onDayPass;

		// Token: 0x040015D4 RID: 5588
		private static readonly IntPtr NativeFieldInfoPtr_onWeekPass;

		// Token: 0x040015D5 RID: 5589
		private static readonly IntPtr NativeFieldInfoPtr_onUpdate;

		// Token: 0x040015D6 RID: 5590
		private static readonly IntPtr NativeFieldInfoPtr_onFixedUpdate;

		// Token: 0x040015D7 RID: 5591
		private static readonly IntPtr NativeFieldInfoPtr_onTimeSkip;

		// Token: 0x040015D8 RID: 5592
		private static readonly IntPtr NativeFieldInfoPtr_onTick;

		// Token: 0x040015D9 RID: 5593
		private static readonly IntPtr NativeFieldInfoPtr_onSleepStart;

		// Token: 0x040015DA RID: 5594
		private static readonly IntPtr NativeFieldInfoPtr__onSleepStart;

		// Token: 0x040015DB RID: 5595
		private static readonly IntPtr NativeFieldInfoPtr_onSleepEnd;

		// Token: 0x040015DC RID: 5596
		private static readonly IntPtr NativeFieldInfoPtr__onSleepEnd;

		// Token: 0x040015DD RID: 5597
		private static readonly IntPtr NativeFieldInfoPtr_onFirstNight;

		// Token: 0x040015DE RID: 5598
		private static readonly IntPtr NativeFieldInfoPtr_onTimeChanged;

		// Token: 0x040015DF RID: 5599
		private static readonly IntPtr NativeFieldInfoPtr_SelectedWakeTime;

		// Token: 0x040015E0 RID: 5600
		private static readonly IntPtr NativeFieldInfoPtr_sleepStartTime;

		// Token: 0x040015E1 RID: 5601
		private static readonly IntPtr NativeFieldInfoPtr_sleepEndTime;

		// Token: 0x040015E2 RID: 5602
		private static readonly IntPtr NativeFieldInfoPtr__HostDailySummaryDone_k__BackingField;

		// Token: 0x040015E3 RID: 5603
		private static readonly IntPtr NativeFieldInfoPtr_defaultFixedTimeScale;

		// Token: 0x040015E4 RID: 5604
		private static readonly IntPtr NativeFieldInfoPtr_loader;

		// Token: 0x040015E5 RID: 5605
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x040015E6 RID: 5606
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x040015E7 RID: 5607
		private static readonly IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x040015E8 RID: 5608
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040015E9 RID: 5609
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040015EA RID: 5610
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEndOfDay_Public_get_Boolean_0;

		// Token: 0x040015EB RID: 5611
		private static readonly IntPtr NativeMethodInfoPtr_get_SleepInProgress_Public_get_Boolean_0;

		// Token: 0x040015EC RID: 5612
		private static readonly IntPtr NativeMethodInfoPtr_set_SleepInProgress_Protected_set_Void_Boolean_0;

		// Token: 0x040015ED RID: 5613
		private static readonly IntPtr NativeMethodInfoPtr_get_ElapsedDays_Public_get_Int32_0;

		// Token: 0x040015EE RID: 5614
		private static readonly IntPtr NativeMethodInfoPtr_set_ElapsedDays_Protected_set_Void_Int32_0;

		// Token: 0x040015EF RID: 5615
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentTime_Public_get_Int32_0;

		// Token: 0x040015F0 RID: 5616
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentTime_Protected_set_Void_Int32_0;

		// Token: 0x040015F1 RID: 5617
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeOnCurrentMinute_Public_get_Single_0;

		// Token: 0x040015F2 RID: 5618
		private static readonly IntPtr NativeMethodInfoPtr_set_TimeOnCurrentMinute_Protected_set_Void_Single_0;

		// Token: 0x040015F3 RID: 5619
		private static readonly IntPtr NativeMethodInfoPtr_get_DailyMinTotal_Public_get_Int32_0;

		// Token: 0x040015F4 RID: 5620
		private static readonly IntPtr NativeMethodInfoPtr_set_DailyMinTotal_Protected_set_Void_Int32_0;

		// Token: 0x040015F5 RID: 5621
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNight_Public_get_Boolean_0;

		// Token: 0x040015F6 RID: 5622
		private static readonly IntPtr NativeMethodInfoPtr_get_DayIndex_Public_get_Int32_0;

		// Token: 0x040015F7 RID: 5623
		private static readonly IntPtr NativeMethodInfoPtr_get_NormalizedTime_Public_get_Single_0;

		// Token: 0x040015F8 RID: 5624
		private static readonly IntPtr NativeMethodInfoPtr_get_Playtime_Public_get_Single_0;

		// Token: 0x040015F9 RID: 5625
		private static readonly IntPtr NativeMethodInfoPtr_set_Playtime_Protected_set_Void_Single_0;

		// Token: 0x040015FA RID: 5626
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentDay_Public_get_EDay_0;

		// Token: 0x040015FB RID: 5627
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeOverridden_Public_get_Boolean_0;

		// Token: 0x040015FC RID: 5628
		private static readonly IntPtr NativeMethodInfoPtr_set_TimeOverridden_Protected_set_Void_Boolean_0;

		// Token: 0x040015FD RID: 5629
		private static readonly IntPtr NativeMethodInfoPtr_get_HostDailySummaryDone_Public_get_Boolean_0;

		// Token: 0x040015FE RID: 5630
		private static readonly IntPtr NativeMethodInfoPtr_set_HostDailySummaryDone_Private_set_Void_Boolean_0;

		// Token: 0x040015FF RID: 5631
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04001600 RID: 5632
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04001601 RID: 5633
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x04001602 RID: 5634
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001603 RID: 5635
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04001604 RID: 5636
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04001605 RID: 5637
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04001606 RID: 5638
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04001607 RID: 5639
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001608 RID: 5640
		private static readonly IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04001609 RID: 5641
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x0400160A RID: 5642
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x0400160B RID: 5643
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x0400160C RID: 5644
		private static readonly IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0;

		// Token: 0x0400160D RID: 5645
		private static readonly IntPtr NativeMethodInfoPtr_Clean_Private_Void_0;

		// Token: 0x0400160E RID: 5646
		private static readonly IntPtr NativeMethodInfoPtr_SendTimeData_Public_Void_NetworkConnection_0;

		// Token: 0x0400160F RID: 5647
		private static readonly IntPtr NativeMethodInfoPtr_SetData_Private_Void_NetworkConnection_Int32_Int32_Single_0;

		// Token: 0x04001610 RID: 5648
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04001611 RID: 5649
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04001612 RID: 5650
		private static readonly IntPtr NativeMethodInfoPtr_ResetHostSleepDone_Public_Void_0;

		// Token: 0x04001613 RID: 5651
		private static readonly IntPtr NativeMethodInfoPtr_MarkHostSleepDone_Public_Void_0;

		// Token: 0x04001614 RID: 5652
		private static readonly IntPtr NativeMethodInfoPtr_SetHostSleepDone_Private_Void_Boolean_0;

		// Token: 0x04001615 RID: 5653
		private static readonly IntPtr NativeMethodInfoPtr_TickLoop_Private_IEnumerator_0;

		// Token: 0x04001616 RID: 5654
		private static readonly IntPtr NativeMethodInfoPtr_TimeLoop_Private_IEnumerator_0;

		// Token: 0x04001617 RID: 5655
		private static readonly IntPtr NativeMethodInfoPtr_StaggeredMinPass_Private_IEnumerator_Single_0;

		// Token: 0x04001618 RID: 5656
		private static readonly IntPtr NativeMethodInfoPtr_Tick_Private_Void_0;

		// Token: 0x04001619 RID: 5657
		private static readonly IntPtr NativeMethodInfoPtr_SetTime_Public_Void_Int32_Boolean_0;

		// Token: 0x0400161A RID: 5658
		private static readonly IntPtr NativeMethodInfoPtr_SetElapsedDays_Public_Void_Int32_0;

		// Token: 0x0400161B RID: 5659
		private static readonly IntPtr NativeMethodInfoPtr_Get12HourTime_Public_Static_String_Single_Boolean_0;

		// Token: 0x0400161C RID: 5660
		private static readonly IntPtr NativeMethodInfoPtr_Get24HourTimeFromMinSum_Public_Static_Int32_Int32_0;

		// Token: 0x0400161D RID: 5661
		private static readonly IntPtr NativeMethodInfoPtr_GetMinSumFrom24HourTime_Public_Static_Int32_Int32_0;

		// Token: 0x0400161E RID: 5662
		private static readonly IntPtr NativeMethodInfoPtr_IsCurrentTimeWithinRange_Public_Boolean_Int32_Int32_0;

		// Token: 0x0400161F RID: 5663
		private static readonly IntPtr NativeMethodInfoPtr_IsGivenTimeWithinRange_Public_Static_Boolean_Int32_Int32_Int32_0;

		// Token: 0x04001620 RID: 5664
		private static readonly IntPtr NativeMethodInfoPtr_IsValid24HourTime_Public_Static_Boolean_String_0;

		// Token: 0x04001621 RID: 5665
		private static readonly IntPtr NativeMethodInfoPtr_IsCurrentDateWithinRange_Public_Boolean_GameDateTime_GameDateTime_0;

		// Token: 0x04001622 RID: 5666
		private static readonly IntPtr NativeMethodInfoPtr_InvokeDayPassClientSide_Private_Void_0;

		// Token: 0x04001623 RID: 5667
		private static readonly IntPtr NativeMethodInfoPtr_InvokeWeekPassClientSide_Private_Void_0;

		// Token: 0x04001624 RID: 5668
		private static readonly IntPtr NativeMethodInfoPtr_FastForwardToWakeTime_Public_Void_0;

		// Token: 0x04001625 RID: 5669
		private static readonly IntPtr NativeMethodInfoPtr_GetDateTime_Public_GameDateTime_0;

		// Token: 0x04001626 RID: 5670
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalMinSum_Public_Int32_0;

		// Token: 0x04001627 RID: 5671
		private static readonly IntPtr NativeMethodInfoPtr_AddMinutesTo24HourTime_Public_Static_Int32_Int32_Int32_0;

		// Token: 0x04001628 RID: 5672
		private static readonly IntPtr NativeMethodInfoPtr_GetAllTimeInRange_Public_Static_List_1_Int32_Int32_Int32_0;

		// Token: 0x04001629 RID: 5673
		private static readonly IntPtr NativeMethodInfoPtr_SetWakeTime_Public_Void_Int32_0;

		// Token: 0x0400162A RID: 5674
		private static readonly IntPtr NativeMethodInfoPtr_StartSleep_Private_Void_0;

		// Token: 0x0400162B RID: 5675
		private static readonly IntPtr NativeMethodInfoPtr_EndSleep_Private_Void_0;

		// Token: 0x0400162C RID: 5676
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x0400162D RID: 5677
		private static readonly IntPtr NativeMethodInfoPtr_SetPlaytime_Public_Void_Single_0;

		// Token: 0x0400162E RID: 5678
		private static readonly IntPtr NativeMethodInfoPtr_SetTimeOverridden_Public_Void_Boolean_Int32_0;

		// Token: 0x0400162F RID: 5679
		private static readonly IntPtr NativeMethodInfoPtr_SetRandomTime_Private_Void_0;

		// Token: 0x04001630 RID: 5680
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001631 RID: 5681
		private static readonly IntPtr NativeMethodInfoPtr__TimeLoop_b__102_0_Private_Boolean_0;

		// Token: 0x04001632 RID: 5682
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04001633 RID: 5683
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04001634 RID: 5684
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04001635 RID: 5685
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetData_2661156041_Private_Void_NetworkConnection_Int32_Int32_Single_0;

		// Token: 0x04001636 RID: 5686
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetData_2661156041_Private_Void_NetworkConnection_Int32_Int32_Single_0;

		// Token: 0x04001637 RID: 5687
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetData_2661156041_Private_Void_PooledReader_Channel_0;

		// Token: 0x04001638 RID: 5688
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetData_2661156041_Private_Void_NetworkConnection_Int32_Int32_Single_0;

		// Token: 0x04001639 RID: 5689
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetData_2661156041_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400163A RID: 5690
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_ResetHostSleepDone_2166136261_Private_Void_0;

		// Token: 0x0400163B RID: 5691
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___ResetHostSleepDone_2166136261_Public_Void_0;

		// Token: 0x0400163C RID: 5692
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_ResetHostSleepDone_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400163D RID: 5693
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_MarkHostSleepDone_2166136261_Private_Void_0;

		// Token: 0x0400163E RID: 5694
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___MarkHostSleepDone_2166136261_Public_Void_0;

		// Token: 0x0400163F RID: 5695
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_MarkHostSleepDone_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04001640 RID: 5696
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetHostSleepDone_1140765316_Private_Void_Boolean_0;

		// Token: 0x04001641 RID: 5697
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetHostSleepDone_1140765316_Private_Void_Boolean_0;

		// Token: 0x04001642 RID: 5698
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetHostSleepDone_1140765316_Private_Void_PooledReader_Channel_0;

		// Token: 0x04001643 RID: 5699
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_InvokeDayPassClientSide_2166136261_Private_Void_0;

		// Token: 0x04001644 RID: 5700
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___InvokeDayPassClientSide_2166136261_Private_Void_0;

		// Token: 0x04001645 RID: 5701
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_InvokeDayPassClientSide_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04001646 RID: 5702
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_InvokeWeekPassClientSide_2166136261_Private_Void_0;

		// Token: 0x04001647 RID: 5703
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___InvokeWeekPassClientSide_2166136261_Private_Void_0;

		// Token: 0x04001648 RID: 5704
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_InvokeWeekPassClientSide_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04001649 RID: 5705
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetWakeTime_3316948804_Private_Void_Int32_0;

		// Token: 0x0400164A RID: 5706
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetWakeTime_3316948804_Public_Void_Int32_0;

		// Token: 0x0400164B RID: 5707
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetWakeTime_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400164C RID: 5708
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_StartSleep_2166136261_Private_Void_0;

		// Token: 0x0400164D RID: 5709
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___StartSleep_2166136261_Private_Void_0;

		// Token: 0x0400164E RID: 5710
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_StartSleep_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400164F RID: 5711
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_EndSleep_2166136261_Private_Void_0;

		// Token: 0x04001650 RID: 5712
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___EndSleep_2166136261_Private_Void_0;

		// Token: 0x04001651 RID: 5713
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_EndSleep_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04001652 RID: 5714
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x020008B9 RID: 2233
		[ObfuscatedName("ScheduleOne.GameTime.TimeManager+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600C32C RID: 49964 RVA: 0x002F9EE8 File Offset: 0x002F80E8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c>.NativeClassPtr);
				Il2CppScheduleOne.GameTime.TimeManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c>.NativeClassPtr, "<>9");
				Il2CppScheduleOne.GameTime.TimeManager.__c.NativeFieldInfoPtr___9__101_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c>.NativeClassPtr, "<>9__101_0");
				Il2CppScheduleOne.GameTime.TimeManager.__c.NativeFieldInfoPtr___9__102_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c>.NativeClassPtr, "<>9__102_1");
				Il2CppScheduleOne.GameTime.TimeManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c>.NativeClassPtr, 100667060);
				Il2CppScheduleOne.GameTime.TimeManager.__c.NativeMethodInfoPtr__TickLoop_b__101_0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c>.NativeClassPtr, 100667061);
				Il2CppScheduleOne.GameTime.TimeManager.__c.NativeMethodInfoPtr__TimeLoop_b__102_1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c>.NativeClassPtr, 100667062);
			}

			// Token: 0x0600C32D RID: 49965 RVA: 0x002F9F8C File Offset: 0x002F818C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C32E RID: 49966 RVA: 0x002F9FC8 File Offset: 0x002F81C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109186, XrefRangeEnd = 109187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _TickLoop_b__101_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.__c.NativeMethodInfoPtr__TickLoop_b__101_0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C32F RID: 49967 RVA: 0x002FA004 File Offset: 0x002F8204
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _TimeLoop_b__102_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.__c.NativeMethodInfoPtr__TimeLoop_b__102_1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C330 RID: 49968 RVA: 0x0005EFBE File Offset: 0x0005D1BE
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003CEF RID: 15599
			// (get) Token: 0x0600C331 RID: 49969 RVA: 0x002FA040 File Offset: 0x002F8240
			// (set) Token: 0x0600C332 RID: 49970 RVA: 0x0005EFC7 File Offset: 0x0005D1C7
			public unsafe static TimeManager.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Il2CppScheduleOne.GameTime.TimeManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimeManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Il2CppScheduleOne.GameTime.TimeManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CF0 RID: 15600
			// (get) Token: 0x0600C333 RID: 49971 RVA: 0x002FA068 File Offset: 0x002F8268
			// (set) Token: 0x0600C334 RID: 49972 RVA: 0x0005EFD9 File Offset: 0x0005D1D9
			public unsafe static Func<bool> __9__101_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Il2CppScheduleOne.GameTime.TimeManager.__c.NativeFieldInfoPtr___9__101_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Il2CppScheduleOne.GameTime.TimeManager.__c.NativeFieldInfoPtr___9__101_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CF1 RID: 15601
			// (get) Token: 0x0600C335 RID: 49973 RVA: 0x002FA090 File Offset: 0x002F8290
			// (set) Token: 0x0600C336 RID: 49974 RVA: 0x0005EFEB File Offset: 0x0005D1EB
			public unsafe static Func<bool> __9__102_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Il2CppScheduleOne.GameTime.TimeManager.__c.NativeFieldInfoPtr___9__102_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Il2CppScheduleOne.GameTime.TimeManager.__c.NativeFieldInfoPtr___9__102_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400845F RID: 33887
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008460 RID: 33888
			private static readonly IntPtr NativeFieldInfoPtr___9__101_0;

			// Token: 0x04008461 RID: 33889
			private static readonly IntPtr NativeFieldInfoPtr___9__102_1;

			// Token: 0x04008462 RID: 33890
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008463 RID: 33891
			private static readonly IntPtr NativeMethodInfoPtr__TickLoop_b__101_0_Internal_Boolean_0;

			// Token: 0x04008464 RID: 33892
			private static readonly IntPtr NativeMethodInfoPtr__TimeLoop_b__102_1_Internal_Boolean_0;
		}

		// Token: 0x020008BA RID: 2234
		[ObfuscatedName("ScheduleOne.GameTime.TimeManager+<>c__DisplayClass94_0")]
		public sealed class __c__DisplayClass94_0 : Object
		{
			// Token: 0x0600C337 RID: 49975 RVA: 0x002FA0B8 File Offset: 0x002F82B8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass94_0()
			{
				Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "<>c__DisplayClass94_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0>.NativeClassPtr);
				Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.NativeFieldInfoPtr_connection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0>.NativeClassPtr, "connection");
				Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0>.NativeClassPtr, "<>4__this");
				Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0>.NativeClassPtr, 100667063);
				Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0>.NativeClassPtr, 100667064);
				Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.NativeMethodInfoPtr__SendTimeData_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0>.NativeClassPtr, 100667065);
			}

			// Token: 0x0600C338 RID: 49976 RVA: 0x002FA148 File Offset: 0x002F8348
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass94_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C339 RID: 49977 RVA: 0x002FA184 File Offset: 0x002F8384
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109204, XrefRangeEnd = 109209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600C33A RID: 49978 RVA: 0x002FA1C4 File Offset: 0x002F83C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109209, XrefRangeEnd = 109217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SendTimeData_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.NativeMethodInfoPtr__SendTimeData_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C33B RID: 49979 RVA: 0x0005EFFD File Offset: 0x0005D1FD
			public __c__DisplayClass94_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003CF2 RID: 15602
			// (get) Token: 0x0600C33C RID: 49980 RVA: 0x002FA200 File Offset: 0x002F8400
			// (set) Token: 0x0600C33D RID: 49981 RVA: 0x0005F006 File Offset: 0x0005D206
			public unsafe NetworkConnection connection
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.NativeFieldInfoPtr_connection);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkConnection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.NativeFieldInfoPtr_connection), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CF3 RID: 15603
			// (get) Token: 0x0600C33E RID: 49982 RVA: 0x002FA230 File Offset: 0x002F8430
			// (set) Token: 0x0600C33F RID: 49983 RVA: 0x0005F025 File Offset: 0x0005D225
			public unsafe TimeManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimeManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008465 RID: 33893
			private static readonly IntPtr NativeFieldInfoPtr_connection;

			// Token: 0x04008466 RID: 33894
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008467 RID: 33895
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008468 RID: 33896
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04008469 RID: 33897
			private static readonly IntPtr NativeMethodInfoPtr__SendTimeData_b__1_Internal_Boolean_0;

			// Token: 0x02000C30 RID: 3120
			[ObfuscatedName("ScheduleOne.GameTime.TimeManager+<>c__DisplayClass94_0+<<SendTimeData>g__WaitForPlayerReady|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Object
			{
				// Token: 0x0600E12D RID: 57645 RVA: 0x0034EF08 File Offset: 0x0034D108
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0>.NativeClassPtr, "<<SendTimeData>g__WaitForPlayerReady|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100667066);
					Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100667067);
					Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100667068);
					Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100667069);
					Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100667070);
					Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100667071);
				}

				// Token: 0x0600E12E RID: 57646 RVA: 0x0034EFE8 File Offset: 0x0034D1E8
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E12F RID: 57647 RVA: 0x0034F030 File Offset: 0x0034D230
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E130 RID: 57648 RVA: 0x0034F064 File Offset: 0x0034D264
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109187, XrefRangeEnd = 109199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170045C4 RID: 17860
				// (get) Token: 0x0600E131 RID: 57649 RVA: 0x0034F0A0 File Offset: 0x0034D2A0
				public unsafe Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E132 RID: 57650 RVA: 0x0034F0E0 File Offset: 0x0034D2E0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109199, XrefRangeEnd = 109204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170045C5 RID: 17861
				// (get) Token: 0x0600E133 RID: 57651 RVA: 0x0034F114 File Offset: 0x0034D314
				public unsafe Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E134 RID: 57652 RVA: 0x0006DC9D File Offset: 0x0006BE9D
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170045C1 RID: 17857
				// (get) Token: 0x0600E135 RID: 57653 RVA: 0x0034F154 File Offset: 0x0034D354
				// (set) Token: 0x0600E136 RID: 57654 RVA: 0x0006DCA6 File Offset: 0x0006BEA6
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170045C2 RID: 17858
				// (get) Token: 0x0600E137 RID: 57655 RVA: 0x0034F17C File Offset: 0x0034D37C
				// (set) Token: 0x0600E138 RID: 57656 RVA: 0x0006DCC1 File Offset: 0x0006BEC1
				public unsafe Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170045C3 RID: 17859
				// (get) Token: 0x0600E139 RID: 57657 RVA: 0x0034F1AC File Offset: 0x0034D3AC
				// (set) Token: 0x0600E13A RID: 57658 RVA: 0x0006DCE0 File Offset: 0x0006BEE0
				public unsafe TimeManager.__c__DisplayClass94_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimeManager.__c__DisplayClass94_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager.__c__DisplayClass94_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x040096C6 RID: 38598
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x040096C7 RID: 38599
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x040096C8 RID: 38600
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x040096C9 RID: 38601
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x040096CA RID: 38602
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x040096CB RID: 38603
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x040096CC RID: 38604
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x040096CD RID: 38605
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x040096CE RID: 38606
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x020008BB RID: 2235
		[ObfuscatedName("ScheduleOne.GameTime.TimeManager+<StaggeredMinPass>d__103")]
		public sealed class _StaggeredMinPass_d__103 : Object
		{
			// Token: 0x0600C340 RID: 49984 RVA: 0x002FA260 File Offset: 0x002F8460
			// Note: this type is marked as 'beforefieldinit'.
			static _StaggeredMinPass_d__103()
			{
				Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "<StaggeredMinPass>d__103");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103>.NativeClassPtr);
				Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103>.NativeClassPtr, "<>1__state");
				Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103>.NativeClassPtr, "<>2__current");
				Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103>.NativeClassPtr, "<>4__this");
				Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr_staggerTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103>.NativeClassPtr, "staggerTime");
				Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr__listeners_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103>.NativeClassPtr, "<listeners>5__2");
				Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr__perDelay_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103>.NativeClassPtr, "<perDelay>5__3");
				Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr__startTime_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103>.NativeClassPtr, "<startTime>5__4");
				Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr__waitOverflow_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103>.NativeClassPtr, "<waitOverflow>5__5");
				Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr__timeOnWaitStart_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103>.NativeClassPtr, "<timeOnWaitStart>5__6");
				Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr__loopsSinceLastWait_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103>.NativeClassPtr, "<loopsSinceLastWait>5__7");
				Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr__i_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103>.NativeClassPtr, "<i>5__8");
				Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103>.NativeClassPtr, 100667072);
				Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103>.NativeClassPtr, 100667073);
				Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103>.NativeClassPtr, 100667074);
				Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103>.NativeClassPtr, 100667075);
				Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103>.NativeClassPtr, 100667076);
				Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103>.NativeClassPtr, 100667077);
			}

			// Token: 0x0600C341 RID: 49985 RVA: 0x002FA3E0 File Offset: 0x002F85E0
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _StaggeredMinPass_d__103(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C342 RID: 49986 RVA: 0x002FA428 File Offset: 0x002F8628
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C343 RID: 49987 RVA: 0x002FA45C File Offset: 0x002F865C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109217, XrefRangeEnd = 109244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003CFF RID: 15615
			// (get) Token: 0x0600C344 RID: 49988 RVA: 0x002FA498 File Offset: 0x002F8698
			public unsafe Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C345 RID: 49989 RVA: 0x002FA4D8 File Offset: 0x002F86D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109244, XrefRangeEnd = 109249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003D00 RID: 15616
			// (get) Token: 0x0600C346 RID: 49990 RVA: 0x002FA50C File Offset: 0x002F870C
			public unsafe Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C347 RID: 49991 RVA: 0x0005F044 File Offset: 0x0005D244
			public _StaggeredMinPass_d__103(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003CF4 RID: 15604
			// (get) Token: 0x0600C348 RID: 49992 RVA: 0x002FA54C File Offset: 0x002F874C
			// (set) Token: 0x0600C349 RID: 49993 RVA: 0x0005F04D File Offset: 0x0005D24D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003CF5 RID: 15605
			// (get) Token: 0x0600C34A RID: 49994 RVA: 0x002FA574 File Offset: 0x002F8774
			// (set) Token: 0x0600C34B RID: 49995 RVA: 0x0005F068 File Offset: 0x0005D268
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CF6 RID: 15606
			// (get) Token: 0x0600C34C RID: 49996 RVA: 0x002FA5A4 File Offset: 0x002F87A4
			// (set) Token: 0x0600C34D RID: 49997 RVA: 0x0005F087 File Offset: 0x0005D287
			public unsafe TimeManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimeManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CF7 RID: 15607
			// (get) Token: 0x0600C34E RID: 49998 RVA: 0x002FA5D4 File Offset: 0x002F87D4
			// (set) Token: 0x0600C34F RID: 49999 RVA: 0x0005F0A6 File Offset: 0x0005D2A6
			public unsafe float staggerTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr_staggerTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr_staggerTime)) = value;
				}
			}

			// Token: 0x17003CF8 RID: 15608
			// (get) Token: 0x0600C350 RID: 50000 RVA: 0x002FA5FC File Offset: 0x002F87FC
			// (set) Token: 0x0600C351 RID: 50001 RVA: 0x0005F0C1 File Offset: 0x0005D2C1
			public unsafe Il2CppReferenceArray<Delegate> _listeners_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr__listeners_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Delegate>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr__listeners_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CF9 RID: 15609
			// (get) Token: 0x0600C352 RID: 50002 RVA: 0x002FA62C File Offset: 0x002F882C
			// (set) Token: 0x0600C353 RID: 50003 RVA: 0x0005F0E0 File Offset: 0x0005D2E0
			public unsafe float _perDelay_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr__perDelay_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr__perDelay_5__3)) = value;
				}
			}

			// Token: 0x17003CFA RID: 15610
			// (get) Token: 0x0600C354 RID: 50004 RVA: 0x002FA654 File Offset: 0x002F8854
			// (set) Token: 0x0600C355 RID: 50005 RVA: 0x0005F0FB File Offset: 0x0005D2FB
			public unsafe float _startTime_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr__startTime_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr__startTime_5__4)) = value;
				}
			}

			// Token: 0x17003CFB RID: 15611
			// (get) Token: 0x0600C356 RID: 50006 RVA: 0x002FA67C File Offset: 0x002F887C
			// (set) Token: 0x0600C357 RID: 50007 RVA: 0x0005F116 File Offset: 0x0005D316
			public unsafe float _waitOverflow_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr__waitOverflow_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr__waitOverflow_5__5)) = value;
				}
			}

			// Token: 0x17003CFC RID: 15612
			// (get) Token: 0x0600C358 RID: 50008 RVA: 0x002FA6A4 File Offset: 0x002F88A4
			// (set) Token: 0x0600C359 RID: 50009 RVA: 0x0005F131 File Offset: 0x0005D331
			public unsafe float _timeOnWaitStart_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr__timeOnWaitStart_5__6);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr__timeOnWaitStart_5__6)) = value;
				}
			}

			// Token: 0x17003CFD RID: 15613
			// (get) Token: 0x0600C35A RID: 50010 RVA: 0x002FA6CC File Offset: 0x002F88CC
			// (set) Token: 0x0600C35B RID: 50011 RVA: 0x0005F14C File Offset: 0x0005D34C
			public unsafe int _loopsSinceLastWait_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr__loopsSinceLastWait_5__7);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr__loopsSinceLastWait_5__7)) = value;
				}
			}

			// Token: 0x17003CFE RID: 15614
			// (get) Token: 0x0600C35C RID: 50012 RVA: 0x002FA6F4 File Offset: 0x002F88F4
			// (set) Token: 0x0600C35D RID: 50013 RVA: 0x0005F167 File Offset: 0x0005D367
			public unsafe int _i_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr__i_5__8);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._StaggeredMinPass_d__103.NativeFieldInfoPtr__i_5__8)) = value;
				}
			}

			// Token: 0x0400846A RID: 33898
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400846B RID: 33899
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400846C RID: 33900
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400846D RID: 33901
			private static readonly IntPtr NativeFieldInfoPtr_staggerTime;

			// Token: 0x0400846E RID: 33902
			private static readonly IntPtr NativeFieldInfoPtr__listeners_5__2;

			// Token: 0x0400846F RID: 33903
			private static readonly IntPtr NativeFieldInfoPtr__perDelay_5__3;

			// Token: 0x04008470 RID: 33904
			private static readonly IntPtr NativeFieldInfoPtr__startTime_5__4;

			// Token: 0x04008471 RID: 33905
			private static readonly IntPtr NativeFieldInfoPtr__waitOverflow_5__5;

			// Token: 0x04008472 RID: 33906
			private static readonly IntPtr NativeFieldInfoPtr__timeOnWaitStart_5__6;

			// Token: 0x04008473 RID: 33907
			private static readonly IntPtr NativeFieldInfoPtr__loopsSinceLastWait_5__7;

			// Token: 0x04008474 RID: 33908
			private static readonly IntPtr NativeFieldInfoPtr__i_5__8;

			// Token: 0x04008475 RID: 33909
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008476 RID: 33910
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008477 RID: 33911
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008478 RID: 33912
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008479 RID: 33913
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400847A RID: 33914
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020008BC RID: 2236
		[ObfuscatedName("ScheduleOne.GameTime.TimeManager+<TickLoop>d__101")]
		public sealed class _TickLoop_d__101 : Object
		{
			// Token: 0x0600C35E RID: 50014 RVA: 0x002FA71C File Offset: 0x002F891C
			// Note: this type is marked as 'beforefieldinit'.
			static _TickLoop_d__101()
			{
				Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "<TickLoop>d__101");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101>.NativeClassPtr);
				Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101>.NativeClassPtr, "<>1__state");
				Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101>.NativeClassPtr, "<>2__current");
				Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101>.NativeClassPtr, "<>4__this");
				Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeFieldInfoPtr__lastWaitExcess_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101>.NativeClassPtr, "<lastWaitExcess>5__2");
				Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeFieldInfoPtr__timeToWait_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101>.NativeClassPtr, "<timeToWait>5__3");
				Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeFieldInfoPtr__timeOnWaitStart_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101>.NativeClassPtr, "<timeOnWaitStart>5__4");
				Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101>.NativeClassPtr, 100667078);
				Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101>.NativeClassPtr, 100667079);
				Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101>.NativeClassPtr, 100667080);
				Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101>.NativeClassPtr, 100667081);
				Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101>.NativeClassPtr, 100667082);
				Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101>.NativeClassPtr, 100667083);
			}

			// Token: 0x0600C35F RID: 50015 RVA: 0x002FA838 File Offset: 0x002F8A38
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _TickLoop_d__101(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C360 RID: 50016 RVA: 0x002FA880 File Offset: 0x002F8A80
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C361 RID: 50017 RVA: 0x002FA8B4 File Offset: 0x002F8AB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109249, XrefRangeEnd = 109281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003D07 RID: 15623
			// (get) Token: 0x0600C362 RID: 50018 RVA: 0x002FA8F0 File Offset: 0x002F8AF0
			public unsafe Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C363 RID: 50019 RVA: 0x002FA930 File Offset: 0x002F8B30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109281, XrefRangeEnd = 109286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003D08 RID: 15624
			// (get) Token: 0x0600C364 RID: 50020 RVA: 0x002FA964 File Offset: 0x002F8B64
			public unsafe Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C365 RID: 50021 RVA: 0x0005F182 File Offset: 0x0005D382
			public _TickLoop_d__101(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D01 RID: 15617
			// (get) Token: 0x0600C366 RID: 50022 RVA: 0x002FA9A4 File Offset: 0x002F8BA4
			// (set) Token: 0x0600C367 RID: 50023 RVA: 0x0005F18B File Offset: 0x0005D38B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003D02 RID: 15618
			// (get) Token: 0x0600C368 RID: 50024 RVA: 0x002FA9CC File Offset: 0x002F8BCC
			// (set) Token: 0x0600C369 RID: 50025 RVA: 0x0005F1A6 File Offset: 0x0005D3A6
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D03 RID: 15619
			// (get) Token: 0x0600C36A RID: 50026 RVA: 0x002FA9FC File Offset: 0x002F8BFC
			// (set) Token: 0x0600C36B RID: 50027 RVA: 0x0005F1C5 File Offset: 0x0005D3C5
			public unsafe TimeManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimeManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D04 RID: 15620
			// (get) Token: 0x0600C36C RID: 50028 RVA: 0x002FAA2C File Offset: 0x002F8C2C
			// (set) Token: 0x0600C36D RID: 50029 RVA: 0x0005F1E4 File Offset: 0x0005D3E4
			public unsafe float _lastWaitExcess_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeFieldInfoPtr__lastWaitExcess_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeFieldInfoPtr__lastWaitExcess_5__2)) = value;
				}
			}

			// Token: 0x17003D05 RID: 15621
			// (get) Token: 0x0600C36E RID: 50030 RVA: 0x002FAA54 File Offset: 0x002F8C54
			// (set) Token: 0x0600C36F RID: 50031 RVA: 0x0005F1FF File Offset: 0x0005D3FF
			public unsafe float _timeToWait_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeFieldInfoPtr__timeToWait_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeFieldInfoPtr__timeToWait_5__3)) = value;
				}
			}

			// Token: 0x17003D06 RID: 15622
			// (get) Token: 0x0600C370 RID: 50032 RVA: 0x002FAA7C File Offset: 0x002F8C7C
			// (set) Token: 0x0600C371 RID: 50033 RVA: 0x0005F21A File Offset: 0x0005D41A
			public unsafe float _timeOnWaitStart_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeFieldInfoPtr__timeOnWaitStart_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TickLoop_d__101.NativeFieldInfoPtr__timeOnWaitStart_5__4)) = value;
				}
			}

			// Token: 0x0400847B RID: 33915
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400847C RID: 33916
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400847D RID: 33917
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400847E RID: 33918
			private static readonly IntPtr NativeFieldInfoPtr__lastWaitExcess_5__2;

			// Token: 0x0400847F RID: 33919
			private static readonly IntPtr NativeFieldInfoPtr__timeToWait_5__3;

			// Token: 0x04008480 RID: 33920
			private static readonly IntPtr NativeFieldInfoPtr__timeOnWaitStart_5__4;

			// Token: 0x04008481 RID: 33921
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008482 RID: 33922
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008483 RID: 33923
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008484 RID: 33924
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008485 RID: 33925
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008486 RID: 33926
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020008BD RID: 2237
		[ObfuscatedName("ScheduleOne.GameTime.TimeManager+<TimeLoop>d__102")]
		public sealed class _TimeLoop_d__102 : Object
		{
			// Token: 0x0600C372 RID: 50034 RVA: 0x002FAAA4 File Offset: 0x002F8CA4
			// Note: this type is marked as 'beforefieldinit'.
			static _TimeLoop_d__102()
			{
				Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager>.NativeClassPtr, "<TimeLoop>d__102");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102>.NativeClassPtr);
				Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102>.NativeClassPtr, "<>1__state");
				Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102>.NativeClassPtr, "<>2__current");
				Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102>.NativeClassPtr, "<>4__this");
				Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeFieldInfoPtr__lastWaitExcess_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102>.NativeClassPtr, "<lastWaitExcess>5__2");
				Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeFieldInfoPtr__timeToWait_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102>.NativeClassPtr, "<timeToWait>5__3");
				Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeFieldInfoPtr__timeOnWaitStart_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102>.NativeClassPtr, "<timeOnWaitStart>5__4");
				Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102>.NativeClassPtr, 100667084);
				Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102>.NativeClassPtr, 100667085);
				Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102>.NativeClassPtr, 100667086);
				Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102>.NativeClassPtr, 100667087);
				Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102>.NativeClassPtr, 100667088);
				Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102>.NativeClassPtr, 100667089);
			}

			// Token: 0x0600C373 RID: 50035 RVA: 0x002FABC0 File Offset: 0x002F8DC0
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _TimeLoop_d__102(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C374 RID: 50036 RVA: 0x002FAC08 File Offset: 0x002F8E08
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C375 RID: 50037 RVA: 0x002FAC3C File Offset: 0x002F8E3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109286, XrefRangeEnd = 109303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003D0F RID: 15631
			// (get) Token: 0x0600C376 RID: 50038 RVA: 0x002FAC78 File Offset: 0x002F8E78
			public unsafe Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C377 RID: 50039 RVA: 0x002FACB8 File Offset: 0x002F8EB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109303, XrefRangeEnd = 109308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003D10 RID: 15632
			// (get) Token: 0x0600C378 RID: 50040 RVA: 0x002FACEC File Offset: 0x002F8EEC
			public unsafe Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C379 RID: 50041 RVA: 0x0005F235 File Offset: 0x0005D435
			public _TimeLoop_d__102(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D09 RID: 15625
			// (get) Token: 0x0600C37A RID: 50042 RVA: 0x002FAD2C File Offset: 0x002F8F2C
			// (set) Token: 0x0600C37B RID: 50043 RVA: 0x0005F23E File Offset: 0x0005D43E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003D0A RID: 15626
			// (get) Token: 0x0600C37C RID: 50044 RVA: 0x002FAD54 File Offset: 0x002F8F54
			// (set) Token: 0x0600C37D RID: 50045 RVA: 0x0005F259 File Offset: 0x0005D459
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D0B RID: 15627
			// (get) Token: 0x0600C37E RID: 50046 RVA: 0x002FAD84 File Offset: 0x002F8F84
			// (set) Token: 0x0600C37F RID: 50047 RVA: 0x0005F278 File Offset: 0x0005D478
			public unsafe TimeManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimeManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D0C RID: 15628
			// (get) Token: 0x0600C380 RID: 50048 RVA: 0x002FADB4 File Offset: 0x002F8FB4
			// (set) Token: 0x0600C381 RID: 50049 RVA: 0x0005F297 File Offset: 0x0005D497
			public unsafe float _lastWaitExcess_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeFieldInfoPtr__lastWaitExcess_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeFieldInfoPtr__lastWaitExcess_5__2)) = value;
				}
			}

			// Token: 0x17003D0D RID: 15629
			// (get) Token: 0x0600C382 RID: 50050 RVA: 0x002FADDC File Offset: 0x002F8FDC
			// (set) Token: 0x0600C383 RID: 50051 RVA: 0x0005F2B2 File Offset: 0x0005D4B2
			public unsafe float _timeToWait_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeFieldInfoPtr__timeToWait_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeFieldInfoPtr__timeToWait_5__3)) = value;
				}
			}

			// Token: 0x17003D0E RID: 15630
			// (get) Token: 0x0600C384 RID: 50052 RVA: 0x002FAE04 File Offset: 0x002F9004
			// (set) Token: 0x0600C385 RID: 50053 RVA: 0x0005F2CD File Offset: 0x0005D4CD
			public unsafe float _timeOnWaitStart_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeFieldInfoPtr__timeOnWaitStart_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Il2CppScheduleOne.GameTime.TimeManager._TimeLoop_d__102.NativeFieldInfoPtr__timeOnWaitStart_5__4)) = value;
				}
			}

			// Token: 0x04008487 RID: 33927
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008488 RID: 33928
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008489 RID: 33929
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400848A RID: 33930
			private static readonly IntPtr NativeFieldInfoPtr__lastWaitExcess_5__2;

			// Token: 0x0400848B RID: 33931
			private static readonly IntPtr NativeFieldInfoPtr__timeToWait_5__3;

			// Token: 0x0400848C RID: 33932
			private static readonly IntPtr NativeFieldInfoPtr__timeOnWaitStart_5__4;

			// Token: 0x0400848D RID: 33933
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400848E RID: 33934
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400848F RID: 33935
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008490 RID: 33936
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008491 RID: 33937
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008492 RID: 33938
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
