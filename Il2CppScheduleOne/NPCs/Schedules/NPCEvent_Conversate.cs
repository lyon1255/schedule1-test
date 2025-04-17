using System;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.VoiceOver;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.NPCs.Schedules
{
	// Token: 0x020002DE RID: 734
	public class NPCEvent_Conversate : NPCEvent
	{
		// Token: 0x06003645 RID: 13893 RVA: 0x0011F458 File Offset: 0x0011D658
		// Note: this type is marked as 'beforefieldinit'.
		static NPCEvent_Conversate()
		{
			Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Schedules", "NPCEvent_Conversate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr);
			NPCEvent_Conversate.NativeFieldInfoPtr_ConversationLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, "ConversationLines");
			NPCEvent_Conversate.NativeFieldInfoPtr_AnimationTriggers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, "AnimationTriggers");
			NPCEvent_Conversate.NativeFieldInfoPtr_DESTINATION_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, "DESTINATION_THRESHOLD");
			NPCEvent_Conversate.NativeFieldInfoPtr_TIME_BEFORE_WAIT_START = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, "TIME_BEFORE_WAIT_START");
			NPCEvent_Conversate.NativeFieldInfoPtr_Location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, "Location");
			NPCEvent_Conversate.NativeFieldInfoPtr_IsConversating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, "IsConversating");
			NPCEvent_Conversate.NativeFieldInfoPtr_conversateRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, "conversateRoutine");
			NPCEvent_Conversate.NativeFieldInfoPtr_IsWaiting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, "IsWaiting");
			NPCEvent_Conversate.NativeFieldInfoPtr_OnWaitStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, "OnWaitStart");
			NPCEvent_Conversate.NativeFieldInfoPtr_OnWaitEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, "OnWaitEnd");
			NPCEvent_Conversate.NativeFieldInfoPtr_timeAtDestination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, "timeAtDestination");
			NPCEvent_Conversate.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCEvent_ConversateAssembly-CSharp.dll_Excuted");
			NPCEvent_Conversate.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCEvent_ConversateAssembly-CSharp.dll_Excuted");
			NPCEvent_Conversate.NativeMethodInfoPtr_get_ActionName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100669479);
			NPCEvent_Conversate.NativeMethodInfoPtr_get_StandPoint_Private_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100669480);
			NPCEvent_Conversate.NativeMethodInfoPtr_GetName_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100669481);
			NPCEvent_Conversate.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100669482);
			NPCEvent_Conversate.NativeMethodInfoPtr_Started_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100669483);
			NPCEvent_Conversate.NativeMethodInfoPtr_ActiveUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100669484);
			NPCEvent_Conversate.NativeMethodInfoPtr_MinPassed_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100669485);
			NPCEvent_Conversate.NativeMethodInfoPtr_LateStarted_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100669486);
			NPCEvent_Conversate.NativeMethodInfoPtr_JumpTo_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100669487);
			NPCEvent_Conversate.NativeMethodInfoPtr_End_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100669488);
			NPCEvent_Conversate.NativeMethodInfoPtr_Interrupt_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100669489);
			NPCEvent_Conversate.NativeMethodInfoPtr_Resume_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100669490);
			NPCEvent_Conversate.NativeMethodInfoPtr_IsAtDestination_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100669491);
			NPCEvent_Conversate.NativeMethodInfoPtr_CanConversationStart_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100669492);
			NPCEvent_Conversate.NativeMethodInfoPtr_WalkCallback_Protected_Virtual_Void_WalkResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100669493);
			NPCEvent_Conversate.NativeMethodInfoPtr_StartWait_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100669494);
			NPCEvent_Conversate.NativeMethodInfoPtr_EndWait_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100669495);
			NPCEvent_Conversate.NativeMethodInfoPtr_StartConversate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100669496);
			NPCEvent_Conversate.NativeMethodInfoPtr_EndConversate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100669497);
			NPCEvent_Conversate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100669498);
			NPCEvent_Conversate.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100669499);
			NPCEvent_Conversate.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100669500);
			NPCEvent_Conversate.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100669501);
			NPCEvent_Conversate.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100669502);
			NPCEvent_Conversate.NativeMethodInfoPtr_RpcWriter___Observers_StartWait_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100669503);
			NPCEvent_Conversate.NativeMethodInfoPtr_RpcLogic___StartWait_2166136261_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100669504);
			NPCEvent_Conversate.NativeMethodInfoPtr_RpcReader___Observers_StartWait_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100669505);
			NPCEvent_Conversate.NativeMethodInfoPtr_RpcWriter___Observers_EndWait_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100669506);
			NPCEvent_Conversate.NativeMethodInfoPtr_RpcLogic___EndWait_2166136261_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100669507);
			NPCEvent_Conversate.NativeMethodInfoPtr_RpcReader___Observers_EndWait_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100669508);
			NPCEvent_Conversate.NativeMethodInfoPtr_RpcWriter___Observers_StartConversate_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100669509);
			NPCEvent_Conversate.NativeMethodInfoPtr_RpcLogic___StartConversate_2166136261_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100669510);
			NPCEvent_Conversate.NativeMethodInfoPtr_RpcReader___Observers_StartConversate_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100669511);
			NPCEvent_Conversate.NativeMethodInfoPtr_RpcWriter___Observers_EndConversate_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100669512);
			NPCEvent_Conversate.NativeMethodInfoPtr_RpcLogic___EndConversate_2166136261_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100669513);
			NPCEvent_Conversate.NativeMethodInfoPtr_RpcReader___Observers_EndConversate_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100669514);
			NPCEvent_Conversate.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, 100669515);
		}

		// Token: 0x1700118C RID: 4492
		// (get) Token: 0x06003646 RID: 13894 RVA: 0x0011F870 File Offset: 0x0011DA70
		public new unsafe string ActionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138873, XrefRangeEnd = 138875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_Conversate.NativeMethodInfoPtr_get_ActionName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700118D RID: 4493
		// (get) Token: 0x06003647 RID: 13895 RVA: 0x0011F8A8 File Offset: 0x0011DAA8
		public unsafe Transform StandPoint
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 138883, RefRangeEnd = 138890, XrefRangeStart = 138875, XrefRangeEnd = 138883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_Conversate.NativeMethodInfoPtr_get_StandPoint_Private_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x06003648 RID: 13896 RVA: 0x0011F8E8 File Offset: 0x0011DAE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138890, XrefRangeEnd = 138904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Conversate.NativeMethodInfoPtr_GetName_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003649 RID: 13897 RVA: 0x0011F92C File Offset: 0x0011DB2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138904, XrefRangeEnd = 138911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Conversate.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600364A RID: 13898 RVA: 0x0011F968 File Offset: 0x0011DB68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138911, XrefRangeEnd = 138916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Started()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Conversate.NativeMethodInfoPtr_Started_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600364B RID: 13899 RVA: 0x0011F9A4 File Offset: 0x0011DBA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138916, XrefRangeEnd = 138921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ActiveUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Conversate.NativeMethodInfoPtr_ActiveUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600364C RID: 13900 RVA: 0x0011F9E0 File Offset: 0x0011DBE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138921, XrefRangeEnd = 138926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MinPassed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Conversate.NativeMethodInfoPtr_MinPassed_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600364D RID: 13901 RVA: 0x0011FA1C File Offset: 0x0011DC1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138926, XrefRangeEnd = 138931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void LateStarted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Conversate.NativeMethodInfoPtr_LateStarted_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600364E RID: 13902 RVA: 0x0011FA58 File Offset: 0x0011DC58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138931, XrefRangeEnd = 138942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void JumpTo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Conversate.NativeMethodInfoPtr_JumpTo_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600364F RID: 13903 RVA: 0x0011FA94 File Offset: 0x0011DC94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138942, XrefRangeEnd = 138944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Conversate.NativeMethodInfoPtr_End_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003650 RID: 13904 RVA: 0x0011FAD0 File Offset: 0x0011DCD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138944, XrefRangeEnd = 138950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Interrupt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Conversate.NativeMethodInfoPtr_Interrupt_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003651 RID: 13905 RVA: 0x0011FB0C File Offset: 0x0011DD0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138950, XrefRangeEnd = 138955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Conversate.NativeMethodInfoPtr_Resume_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003652 RID: 13906 RVA: 0x0011FB48 File Offset: 0x0011DD48
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 138964, RefRangeEnd = 138968, XrefRangeStart = 138955, XrefRangeEnd = 138964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAtDestination()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_Conversate.NativeMethodInfoPtr_IsAtDestination_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003653 RID: 13907 RVA: 0x0011FB84 File Offset: 0x0011DD84
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 138989, RefRangeEnd = 138992, XrefRangeStart = 138968, XrefRangeEnd = 138989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanConversationStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_Conversate.NativeMethodInfoPtr_CanConversationStart_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003654 RID: 13908 RVA: 0x0011FBC0 File Offset: 0x0011DDC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138992, XrefRangeEnd = 138996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WalkCallback(NPCMovement.WalkResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Conversate.NativeMethodInfoPtr_WalkCallback_Protected_Virtual_Void_WalkResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003655 RID: 13909 RVA: 0x0011FC0C File Offset: 0x0011DE0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138996, XrefRangeEnd = 139016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StartWait()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Conversate.NativeMethodInfoPtr_StartWait_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003656 RID: 13910 RVA: 0x0011FC48 File Offset: 0x0011DE48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139016, XrefRangeEnd = 139036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void EndWait()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Conversate.NativeMethodInfoPtr_EndWait_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003657 RID: 13911 RVA: 0x0011FC84 File Offset: 0x0011DE84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139036, XrefRangeEnd = 139057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StartConversate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Conversate.NativeMethodInfoPtr_StartConversate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003658 RID: 13912 RVA: 0x0011FCC0 File Offset: 0x0011DEC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139057, XrefRangeEnd = 139077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void EndConversate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Conversate.NativeMethodInfoPtr_EndConversate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003659 RID: 13913 RVA: 0x0011FCFC File Offset: 0x0011DEFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139077, XrefRangeEnd = 139103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCEvent_Conversate() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_Conversate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600365A RID: 13914 RVA: 0x0011FD38 File Offset: 0x0011DF38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139103, XrefRangeEnd = 139108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_Conversate.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600365B RID: 13915 RVA: 0x0011FD78 File Offset: 0x0011DF78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139108, XrefRangeEnd = 139134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Conversate.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600365C RID: 13916 RVA: 0x0011FDB4 File Offset: 0x0011DFB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139134, XrefRangeEnd = 139135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Conversate.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600365D RID: 13917 RVA: 0x0011FDF0 File Offset: 0x0011DFF0
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Conversate.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600365E RID: 13918 RVA: 0x0011FE2C File Offset: 0x0011E02C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139135, XrefRangeEnd = 139153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_StartWait_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_Conversate.NativeMethodInfoPtr_RpcWriter___Observers_StartWait_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600365F RID: 13919 RVA: 0x0011FE60 File Offset: 0x0011E060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139153, XrefRangeEnd = 139154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___StartWait_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Conversate.NativeMethodInfoPtr_RpcLogic___StartWait_2166136261_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003660 RID: 13920 RVA: 0x0011FE9C File Offset: 0x0011E09C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139154, XrefRangeEnd = 139157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_StartWait_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_Conversate.NativeMethodInfoPtr_RpcReader___Observers_StartWait_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003661 RID: 13921 RVA: 0x0011FEEC File Offset: 0x0011E0EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139157, XrefRangeEnd = 139175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_EndWait_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_Conversate.NativeMethodInfoPtr_RpcWriter___Observers_EndWait_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003662 RID: 13922 RVA: 0x0011FF20 File Offset: 0x0011E120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139175, XrefRangeEnd = 139176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___EndWait_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Conversate.NativeMethodInfoPtr_RpcLogic___EndWait_2166136261_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003663 RID: 13923 RVA: 0x0011FF5C File Offset: 0x0011E15C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139176, XrefRangeEnd = 139179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_EndWait_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_Conversate.NativeMethodInfoPtr_RpcReader___Observers_EndWait_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003664 RID: 13924 RVA: 0x0011FFAC File Offset: 0x0011E1AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139179, XrefRangeEnd = 139197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_StartConversate_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_Conversate.NativeMethodInfoPtr_RpcWriter___Observers_StartConversate_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003665 RID: 13925 RVA: 0x0011FFE0 File Offset: 0x0011E1E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 139208, RefRangeEnd = 139210, XrefRangeStart = 139197, XrefRangeEnd = 139208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___StartConversate_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Conversate.NativeMethodInfoPtr_RpcLogic___StartConversate_2166136261_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003666 RID: 13926 RVA: 0x0012001C File Offset: 0x0011E21C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139210, XrefRangeEnd = 139213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_StartConversate_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_Conversate.NativeMethodInfoPtr_RpcReader___Observers_StartConversate_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003667 RID: 13927 RVA: 0x0012006C File Offset: 0x0011E26C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139213, XrefRangeEnd = 139231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_EndConversate_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_Conversate.NativeMethodInfoPtr_RpcWriter___Observers_EndConversate_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003668 RID: 13928 RVA: 0x001200A0 File Offset: 0x0011E2A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139231, XrefRangeEnd = 139232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___EndConversate_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Conversate.NativeMethodInfoPtr_RpcLogic___EndConversate_2166136261_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003669 RID: 13929 RVA: 0x001200DC File Offset: 0x0011E2DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139232, XrefRangeEnd = 139235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_EndConversate_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_Conversate.NativeMethodInfoPtr_RpcReader___Observers_EndConversate_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600366A RID: 13930 RVA: 0x0012012C File Offset: 0x0011E32C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139235, XrefRangeEnd = 139236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Conversate.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600366B RID: 13931 RVA: 0x0001C741 File Offset: 0x0001A941
		public NPCEvent_Conversate(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700117F RID: 4479
		// (get) Token: 0x0600366C RID: 13932 RVA: 0x00120168 File Offset: 0x0011E368
		// (set) Token: 0x0600366D RID: 13933 RVA: 0x0001C74A File Offset: 0x0001A94A
		public unsafe Il2CppStructArray<EVOLineType> ConversationLines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.NativeFieldInfoPtr_ConversationLines);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<EVOLineType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.NativeFieldInfoPtr_ConversationLines), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001180 RID: 4480
		// (get) Token: 0x0600366E RID: 13934 RVA: 0x00120198 File Offset: 0x0011E398
		// (set) Token: 0x0600366F RID: 13935 RVA: 0x0001C769 File Offset: 0x0001A969
		public unsafe Il2CppStringArray AnimationTriggers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.NativeFieldInfoPtr_AnimationTriggers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.NativeFieldInfoPtr_AnimationTriggers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001181 RID: 4481
		// (get) Token: 0x06003670 RID: 13936 RVA: 0x001201C8 File Offset: 0x0011E3C8
		// (set) Token: 0x06003671 RID: 13937 RVA: 0x0001C788 File Offset: 0x0001A988
		public unsafe static float DESTINATION_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCEvent_Conversate.NativeFieldInfoPtr_DESTINATION_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCEvent_Conversate.NativeFieldInfoPtr_DESTINATION_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17001182 RID: 4482
		// (get) Token: 0x06003672 RID: 13938 RVA: 0x001201E4 File Offset: 0x0011E3E4
		// (set) Token: 0x06003673 RID: 13939 RVA: 0x0001C796 File Offset: 0x0001A996
		public unsafe static float TIME_BEFORE_WAIT_START
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCEvent_Conversate.NativeFieldInfoPtr_TIME_BEFORE_WAIT_START, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCEvent_Conversate.NativeFieldInfoPtr_TIME_BEFORE_WAIT_START, (void*)(&value));
			}
		}

		// Token: 0x17001183 RID: 4483
		// (get) Token: 0x06003674 RID: 13940 RVA: 0x00120200 File Offset: 0x0011E400
		// (set) Token: 0x06003675 RID: 13941 RVA: 0x0001C7A4 File Offset: 0x0001A9A4
		public unsafe ConversationLocation Location
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.NativeFieldInfoPtr_Location);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConversationLocation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.NativeFieldInfoPtr_Location), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001184 RID: 4484
		// (get) Token: 0x06003676 RID: 13942 RVA: 0x00120230 File Offset: 0x0011E430
		// (set) Token: 0x06003677 RID: 13943 RVA: 0x0001C7C3 File Offset: 0x0001A9C3
		public unsafe bool IsConversating
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.NativeFieldInfoPtr_IsConversating);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.NativeFieldInfoPtr_IsConversating)) = value;
			}
		}

		// Token: 0x17001185 RID: 4485
		// (get) Token: 0x06003678 RID: 13944 RVA: 0x00120258 File Offset: 0x0011E458
		// (set) Token: 0x06003679 RID: 13945 RVA: 0x0001C7DE File Offset: 0x0001A9DE
		public unsafe Coroutine conversateRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.NativeFieldInfoPtr_conversateRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.NativeFieldInfoPtr_conversateRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001186 RID: 4486
		// (get) Token: 0x0600367A RID: 13946 RVA: 0x00120288 File Offset: 0x0011E488
		// (set) Token: 0x0600367B RID: 13947 RVA: 0x0001C7FD File Offset: 0x0001A9FD
		public unsafe bool IsWaiting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.NativeFieldInfoPtr_IsWaiting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.NativeFieldInfoPtr_IsWaiting)) = value;
			}
		}

		// Token: 0x17001187 RID: 4487
		// (get) Token: 0x0600367C RID: 13948 RVA: 0x001202B0 File Offset: 0x0011E4B0
		// (set) Token: 0x0600367D RID: 13949 RVA: 0x0001C818 File Offset: 0x0001AA18
		public unsafe UnityEvent OnWaitStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.NativeFieldInfoPtr_OnWaitStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.NativeFieldInfoPtr_OnWaitStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001188 RID: 4488
		// (get) Token: 0x0600367E RID: 13950 RVA: 0x001202E0 File Offset: 0x0011E4E0
		// (set) Token: 0x0600367F RID: 13951 RVA: 0x0001C837 File Offset: 0x0001AA37
		public unsafe UnityEvent OnWaitEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.NativeFieldInfoPtr_OnWaitEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.NativeFieldInfoPtr_OnWaitEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001189 RID: 4489
		// (get) Token: 0x06003680 RID: 13952 RVA: 0x00120310 File Offset: 0x0011E510
		// (set) Token: 0x06003681 RID: 13953 RVA: 0x0001C856 File Offset: 0x0001AA56
		public unsafe float timeAtDestination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.NativeFieldInfoPtr_timeAtDestination);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.NativeFieldInfoPtr_timeAtDestination)) = value;
			}
		}

		// Token: 0x1700118A RID: 4490
		// (get) Token: 0x06003682 RID: 13954 RVA: 0x00120338 File Offset: 0x0011E538
		// (set) Token: 0x06003683 RID: 13955 RVA: 0x0001C871 File Offset: 0x0001AA71
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700118B RID: 4491
		// (get) Token: 0x06003684 RID: 13956 RVA: 0x00120360 File Offset: 0x0011E560
		// (set) Token: 0x06003685 RID: 13957 RVA: 0x0001C88C File Offset: 0x0001AA8C
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002384 RID: 9092
		private static readonly IntPtr NativeFieldInfoPtr_ConversationLines;

		// Token: 0x04002385 RID: 9093
		private static readonly IntPtr NativeFieldInfoPtr_AnimationTriggers;

		// Token: 0x04002386 RID: 9094
		private static readonly IntPtr NativeFieldInfoPtr_DESTINATION_THRESHOLD;

		// Token: 0x04002387 RID: 9095
		private static readonly IntPtr NativeFieldInfoPtr_TIME_BEFORE_WAIT_START;

		// Token: 0x04002388 RID: 9096
		private static readonly IntPtr NativeFieldInfoPtr_Location;

		// Token: 0x04002389 RID: 9097
		private static readonly IntPtr NativeFieldInfoPtr_IsConversating;

		// Token: 0x0400238A RID: 9098
		private static readonly IntPtr NativeFieldInfoPtr_conversateRoutine;

		// Token: 0x0400238B RID: 9099
		private static readonly IntPtr NativeFieldInfoPtr_IsWaiting;

		// Token: 0x0400238C RID: 9100
		private static readonly IntPtr NativeFieldInfoPtr_OnWaitStart;

		// Token: 0x0400238D RID: 9101
		private static readonly IntPtr NativeFieldInfoPtr_OnWaitEnd;

		// Token: 0x0400238E RID: 9102
		private static readonly IntPtr NativeFieldInfoPtr_timeAtDestination;

		// Token: 0x0400238F RID: 9103
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002390 RID: 9104
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002391 RID: 9105
		private static readonly IntPtr NativeMethodInfoPtr_get_ActionName_Public_get_String_0;

		// Token: 0x04002392 RID: 9106
		private static readonly IntPtr NativeMethodInfoPtr_get_StandPoint_Private_get_Transform_0;

		// Token: 0x04002393 RID: 9107
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_Virtual_String_0;

		// Token: 0x04002394 RID: 9108
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04002395 RID: 9109
		private static readonly IntPtr NativeMethodInfoPtr_Started_Public_Virtual_Void_0;

		// Token: 0x04002396 RID: 9110
		private static readonly IntPtr NativeMethodInfoPtr_ActiveUpdate_Public_Virtual_Void_0;

		// Token: 0x04002397 RID: 9111
		private static readonly IntPtr NativeMethodInfoPtr_MinPassed_Public_Virtual_Void_0;

		// Token: 0x04002398 RID: 9112
		private static readonly IntPtr NativeMethodInfoPtr_LateStarted_Public_Virtual_Void_0;

		// Token: 0x04002399 RID: 9113
		private static readonly IntPtr NativeMethodInfoPtr_JumpTo_Public_Virtual_Void_0;

		// Token: 0x0400239A RID: 9114
		private static readonly IntPtr NativeMethodInfoPtr_End_Public_Virtual_Void_0;

		// Token: 0x0400239B RID: 9115
		private static readonly IntPtr NativeMethodInfoPtr_Interrupt_Public_Virtual_Void_0;

		// Token: 0x0400239C RID: 9116
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Public_Virtual_Void_0;

		// Token: 0x0400239D RID: 9117
		private static readonly IntPtr NativeMethodInfoPtr_IsAtDestination_Private_Boolean_0;

		// Token: 0x0400239E RID: 9118
		private static readonly IntPtr NativeMethodInfoPtr_CanConversationStart_Private_Boolean_0;

		// Token: 0x0400239F RID: 9119
		private static readonly IntPtr NativeMethodInfoPtr_WalkCallback_Protected_Virtual_Void_WalkResult_0;

		// Token: 0x040023A0 RID: 9120
		private static readonly IntPtr NativeMethodInfoPtr_StartWait_Protected_Virtual_New_Void_0;

		// Token: 0x040023A1 RID: 9121
		private static readonly IntPtr NativeMethodInfoPtr_EndWait_Protected_Virtual_New_Void_0;

		// Token: 0x040023A2 RID: 9122
		private static readonly IntPtr NativeMethodInfoPtr_StartConversate_Protected_Virtual_New_Void_0;

		// Token: 0x040023A3 RID: 9123
		private static readonly IntPtr NativeMethodInfoPtr_EndConversate_Protected_Virtual_New_Void_0;

		// Token: 0x040023A4 RID: 9124
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040023A5 RID: 9125
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x040023A6 RID: 9126
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040023A7 RID: 9127
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040023A8 RID: 9128
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040023A9 RID: 9129
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_StartWait_2166136261_Private_Void_0;

		// Token: 0x040023AA RID: 9130
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___StartWait_2166136261_Protected_Virtual_New_Void_0;

		// Token: 0x040023AB RID: 9131
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_StartWait_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x040023AC RID: 9132
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_EndWait_2166136261_Private_Void_0;

		// Token: 0x040023AD RID: 9133
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___EndWait_2166136261_Protected_Virtual_New_Void_0;

		// Token: 0x040023AE RID: 9134
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_EndWait_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x040023AF RID: 9135
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_StartConversate_2166136261_Private_Void_0;

		// Token: 0x040023B0 RID: 9136
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___StartConversate_2166136261_Protected_Virtual_New_Void_0;

		// Token: 0x040023B1 RID: 9137
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_StartConversate_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x040023B2 RID: 9138
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_EndConversate_2166136261_Private_Void_0;

		// Token: 0x040023B3 RID: 9139
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___EndConversate_2166136261_Protected_Virtual_New_Void_0;

		// Token: 0x040023B4 RID: 9140
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_EndConversate_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x040023B5 RID: 9141
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x0200092E RID: 2350
		[ObfuscatedName("ScheduleOne.NPCs.Schedules.NPCEvent_Conversate+<<StartConversate>g__Routine|30_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600C6BA RID: 50874 RVA: 0x00303E38 File Offset: 0x00302038
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique()
			{
				Il2CppClassPointerStore<NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCEvent_Conversate>.NativeClassPtr, "<<StartConversate>g__Routine|30_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique>.NativeClassPtr);
				NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique>.NativeClassPtr, "<>1__state");
				NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique>.NativeClassPtr, "<>2__current");
				NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique>.NativeClassPtr, "<>4__this");
				NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique.NativeFieldInfoPtr__wait_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique>.NativeClassPtr, "<wait>5__2");
				NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique.NativeFieldInfoPtr__otherNPC_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique>.NativeClassPtr, "<otherNPC>5__3");
				NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique.NativeFieldInfoPtr__t_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique>.NativeClassPtr, "<t>5__4");
				NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique>.NativeClassPtr, 100669516);
				NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique>.NativeClassPtr, 100669517);
				NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique>.NativeClassPtr, 100669518);
				NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique>.NativeClassPtr, 100669519);
				NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique>.NativeClassPtr, 100669520);
				NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique>.NativeClassPtr, 100669521);
			}

			// Token: 0x0600C6BB RID: 50875 RVA: 0x00303F54 File Offset: 0x00302154
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C6BC RID: 50876 RVA: 0x00303F9C File Offset: 0x0030219C
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C6BD RID: 50877 RVA: 0x00303FD0 File Offset: 0x003021D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138821, XrefRangeEnd = 138868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003DED RID: 15853
			// (get) Token: 0x0600C6BE RID: 50878 RVA: 0x0030400C File Offset: 0x0030220C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C6BF RID: 50879 RVA: 0x0030404C File Offset: 0x0030224C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 138868, XrefRangeEnd = 138873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003DEE RID: 15854
			// (get) Token: 0x0600C6C0 RID: 50880 RVA: 0x00304080 File Offset: 0x00302280
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C6C1 RID: 50881 RVA: 0x00060B8F File Offset: 0x0005ED8F
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003DE7 RID: 15847
			// (get) Token: 0x0600C6C2 RID: 50882 RVA: 0x003040C0 File Offset: 0x003022C0
			// (set) Token: 0x0600C6C3 RID: 50883 RVA: 0x00060B98 File Offset: 0x0005ED98
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003DE8 RID: 15848
			// (get) Token: 0x0600C6C4 RID: 50884 RVA: 0x003040E8 File Offset: 0x003022E8
			// (set) Token: 0x0600C6C5 RID: 50885 RVA: 0x00060BB3 File Offset: 0x0005EDB3
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003DE9 RID: 15849
			// (get) Token: 0x0600C6C6 RID: 50886 RVA: 0x00304118 File Offset: 0x00302318
			// (set) Token: 0x0600C6C7 RID: 50887 RVA: 0x00060BD2 File Offset: 0x0005EDD2
			public unsafe NPCEvent_Conversate __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCEvent_Conversate>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003DEA RID: 15850
			// (get) Token: 0x0600C6C8 RID: 50888 RVA: 0x00304148 File Offset: 0x00302348
			// (set) Token: 0x0600C6C9 RID: 50889 RVA: 0x00060BF1 File Offset: 0x0005EDF1
			public unsafe float _wait_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique.NativeFieldInfoPtr__wait_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique.NativeFieldInfoPtr__wait_5__2)) = value;
				}
			}

			// Token: 0x17003DEB RID: 15851
			// (get) Token: 0x0600C6CA RID: 50890 RVA: 0x00304170 File Offset: 0x00302370
			// (set) Token: 0x0600C6CB RID: 50891 RVA: 0x00060C0C File Offset: 0x0005EE0C
			public unsafe NPC _otherNPC_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique.NativeFieldInfoPtr__otherNPC_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique.NativeFieldInfoPtr__otherNPC_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003DEC RID: 15852
			// (get) Token: 0x0600C6CC RID: 50892 RVA: 0x003041A0 File Offset: 0x003023A0
			// (set) Token: 0x0600C6CD RID: 50893 RVA: 0x00060C2B File Offset: 0x0005EE2B
			public unsafe float _t_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique.NativeFieldInfoPtr__t_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Conversate.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNPSiNPSiObObUnique.NativeFieldInfoPtr__t_5__4)) = value;
				}
			}

			// Token: 0x0400867F RID: 34431
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008680 RID: 34432
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008681 RID: 34433
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008682 RID: 34434
			private static readonly IntPtr NativeFieldInfoPtr__wait_5__2;

			// Token: 0x04008683 RID: 34435
			private static readonly IntPtr NativeFieldInfoPtr__otherNPC_5__3;

			// Token: 0x04008684 RID: 34436
			private static readonly IntPtr NativeFieldInfoPtr__t_5__4;

			// Token: 0x04008685 RID: 34437
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008686 RID: 34438
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008687 RID: 34439
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008688 RID: 34440
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008689 RID: 34441
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400868A RID: 34442
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
