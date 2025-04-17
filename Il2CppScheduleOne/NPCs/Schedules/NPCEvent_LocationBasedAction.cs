using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.NPCs.Schedules
{
	// Token: 0x020002DF RID: 735
	public class NPCEvent_LocationBasedAction : NPCEvent
	{
		// Token: 0x06003686 RID: 13958 RVA: 0x00120388 File Offset: 0x0011E588
		// Note: this type is marked as 'beforefieldinit'.
		static NPCEvent_LocationBasedAction()
		{
			Il2CppClassPointerStore<NPCEvent_LocationBasedAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Schedules", "NPCEvent_LocationBasedAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCEvent_LocationBasedAction>.NativeClassPtr);
			NPCEvent_LocationBasedAction.NativeFieldInfoPtr_Destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_LocationBasedAction>.NativeClassPtr, "Destination");
			NPCEvent_LocationBasedAction.NativeFieldInfoPtr_FaceDestinationDir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_LocationBasedAction>.NativeClassPtr, "FaceDestinationDir");
			NPCEvent_LocationBasedAction.NativeFieldInfoPtr_DestinationThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_LocationBasedAction>.NativeClassPtr, "DestinationThreshold");
			NPCEvent_LocationBasedAction.NativeFieldInfoPtr_WarpIfSkipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_LocationBasedAction>.NativeClassPtr, "WarpIfSkipped");
			NPCEvent_LocationBasedAction.NativeFieldInfoPtr_IsActionStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_LocationBasedAction>.NativeClassPtr, "IsActionStarted");
			NPCEvent_LocationBasedAction.NativeFieldInfoPtr_onStartAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_LocationBasedAction>.NativeClassPtr, "onStartAction");
			NPCEvent_LocationBasedAction.NativeFieldInfoPtr_onEndAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_LocationBasedAction>.NativeClassPtr, "onEndAction");
			NPCEvent_LocationBasedAction.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_LocationBasedAction>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCEvent_LocationBasedActionAssembly-CSharp.dll_Excuted");
			NPCEvent_LocationBasedAction.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_LocationBasedAction>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCEvent_LocationBasedActionAssembly-CSharp.dll_Excuted");
			NPCEvent_LocationBasedAction.NativeMethodInfoPtr_get_ActionName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_LocationBasedAction>.NativeClassPtr, 100669522);
			NPCEvent_LocationBasedAction.NativeMethodInfoPtr_GetName_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_LocationBasedAction>.NativeClassPtr, 100669523);
			NPCEvent_LocationBasedAction.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_LocationBasedAction>.NativeClassPtr, 100669524);
			NPCEvent_LocationBasedAction.NativeMethodInfoPtr_Started_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_LocationBasedAction>.NativeClassPtr, 100669525);
			NPCEvent_LocationBasedAction.NativeMethodInfoPtr_ActiveMinPassed_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_LocationBasedAction>.NativeClassPtr, 100669526);
			NPCEvent_LocationBasedAction.NativeMethodInfoPtr_LateStarted_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_LocationBasedAction>.NativeClassPtr, 100669527);
			NPCEvent_LocationBasedAction.NativeMethodInfoPtr_JumpTo_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_LocationBasedAction>.NativeClassPtr, 100669528);
			NPCEvent_LocationBasedAction.NativeMethodInfoPtr_End_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_LocationBasedAction>.NativeClassPtr, 100669529);
			NPCEvent_LocationBasedAction.NativeMethodInfoPtr_Interrupt_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_LocationBasedAction>.NativeClassPtr, 100669530);
			NPCEvent_LocationBasedAction.NativeMethodInfoPtr_Resume_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_LocationBasedAction>.NativeClassPtr, 100669531);
			NPCEvent_LocationBasedAction.NativeMethodInfoPtr_Skipped_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_LocationBasedAction>.NativeClassPtr, 100669532);
			NPCEvent_LocationBasedAction.NativeMethodInfoPtr_IsAtDestination_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_LocationBasedAction>.NativeClassPtr, 100669533);
			NPCEvent_LocationBasedAction.NativeMethodInfoPtr_WalkCallback_Protected_Virtual_Void_WalkResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_LocationBasedAction>.NativeClassPtr, 100669534);
			NPCEvent_LocationBasedAction.NativeMethodInfoPtr_StartAction_Protected_Virtual_New_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_LocationBasedAction>.NativeClassPtr, 100669535);
			NPCEvent_LocationBasedAction.NativeMethodInfoPtr_EndAction_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_LocationBasedAction>.NativeClassPtr, 100669536);
			NPCEvent_LocationBasedAction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_LocationBasedAction>.NativeClassPtr, 100669537);
			NPCEvent_LocationBasedAction.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_LocationBasedAction>.NativeClassPtr, 100669538);
			NPCEvent_LocationBasedAction.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_LocationBasedAction>.NativeClassPtr, 100669539);
			NPCEvent_LocationBasedAction.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_LocationBasedAction>.NativeClassPtr, 100669540);
			NPCEvent_LocationBasedAction.NativeMethodInfoPtr_RpcWriter___Observers_StartAction_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_LocationBasedAction>.NativeClassPtr, 100669541);
			NPCEvent_LocationBasedAction.NativeMethodInfoPtr_RpcLogic___StartAction_328543758_Protected_Virtual_New_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_LocationBasedAction>.NativeClassPtr, 100669542);
			NPCEvent_LocationBasedAction.NativeMethodInfoPtr_RpcReader___Observers_StartAction_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_LocationBasedAction>.NativeClassPtr, 100669543);
			NPCEvent_LocationBasedAction.NativeMethodInfoPtr_RpcWriter___Target_StartAction_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_LocationBasedAction>.NativeClassPtr, 100669544);
			NPCEvent_LocationBasedAction.NativeMethodInfoPtr_RpcReader___Target_StartAction_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_LocationBasedAction>.NativeClassPtr, 100669545);
			NPCEvent_LocationBasedAction.NativeMethodInfoPtr_RpcWriter___Observers_EndAction_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_LocationBasedAction>.NativeClassPtr, 100669546);
			NPCEvent_LocationBasedAction.NativeMethodInfoPtr_RpcLogic___EndAction_2166136261_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_LocationBasedAction>.NativeClassPtr, 100669547);
			NPCEvent_LocationBasedAction.NativeMethodInfoPtr_RpcReader___Observers_EndAction_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_LocationBasedAction>.NativeClassPtr, 100669548);
			NPCEvent_LocationBasedAction.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_LocationBasedAction>.NativeClassPtr, 100669549);
		}

		// Token: 0x17001197 RID: 4503
		// (get) Token: 0x06003687 RID: 13959 RVA: 0x0012069C File Offset: 0x0011E89C
		public new unsafe string ActionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139236, XrefRangeEnd = 139238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_LocationBasedAction.NativeMethodInfoPtr_get_ActionName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003688 RID: 13960 RVA: 0x001206D4 File Offset: 0x0011E8D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139238, XrefRangeEnd = 139251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_LocationBasedAction.NativeMethodInfoPtr_GetName_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003689 RID: 13961 RVA: 0x00120718 File Offset: 0x0011E918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139251, XrefRangeEnd = 139252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_LocationBasedAction.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600368A RID: 13962 RVA: 0x00120768 File Offset: 0x0011E968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139252, XrefRangeEnd = 139256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Started()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_LocationBasedAction.NativeMethodInfoPtr_Started_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600368B RID: 13963 RVA: 0x001207A4 File Offset: 0x0011E9A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139256, XrefRangeEnd = 139262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ActiveMinPassed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_LocationBasedAction.NativeMethodInfoPtr_ActiveMinPassed_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600368C RID: 13964 RVA: 0x001207E0 File Offset: 0x0011E9E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139262, XrefRangeEnd = 139266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void LateStarted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_LocationBasedAction.NativeMethodInfoPtr_LateStarted_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600368D RID: 13965 RVA: 0x0012081C File Offset: 0x0011EA1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139266, XrefRangeEnd = 139274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void JumpTo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_LocationBasedAction.NativeMethodInfoPtr_JumpTo_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600368E RID: 13966 RVA: 0x00120858 File Offset: 0x0011EA58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139274, XrefRangeEnd = 139275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_LocationBasedAction.NativeMethodInfoPtr_End_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600368F RID: 13967 RVA: 0x00120894 File Offset: 0x0011EA94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139275, XrefRangeEnd = 139280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Interrupt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_LocationBasedAction.NativeMethodInfoPtr_Interrupt_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003690 RID: 13968 RVA: 0x001208D0 File Offset: 0x0011EAD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139280, XrefRangeEnd = 139284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_LocationBasedAction.NativeMethodInfoPtr_Resume_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003691 RID: 13969 RVA: 0x0012090C File Offset: 0x0011EB0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139284, XrefRangeEnd = 139287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Skipped()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_LocationBasedAction.NativeMethodInfoPtr_Skipped_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003692 RID: 13970 RVA: 0x00120948 File Offset: 0x0011EB48
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 139295, RefRangeEnd = 139305, XrefRangeStart = 139287, XrefRangeEnd = 139295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAtDestination()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_LocationBasedAction.NativeMethodInfoPtr_IsAtDestination_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003693 RID: 13971 RVA: 0x00120984 File Offset: 0x0011EB84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139305, XrefRangeEnd = 139307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WalkCallback(NPCMovement.WalkResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_LocationBasedAction.NativeMethodInfoPtr_WalkCallback_Protected_Virtual_Void_WalkResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003694 RID: 13972 RVA: 0x001209D0 File Offset: 0x0011EBD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139307, XrefRangeEnd = 139344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StartAction(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_LocationBasedAction.NativeMethodInfoPtr_StartAction_Protected_Virtual_New_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003695 RID: 13973 RVA: 0x00120A20 File Offset: 0x0011EC20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139344, XrefRangeEnd = 139364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void EndAction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_LocationBasedAction.NativeMethodInfoPtr_EndAction_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003696 RID: 13974 RVA: 0x00120A5C File Offset: 0x0011EC5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139364, XrefRangeEnd = 139365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCEvent_LocationBasedAction() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCEvent_LocationBasedAction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_LocationBasedAction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003697 RID: 13975 RVA: 0x00120A98 File Offset: 0x0011EC98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139365, XrefRangeEnd = 139385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_LocationBasedAction.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003698 RID: 13976 RVA: 0x00120AD4 File Offset: 0x0011ECD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139385, XrefRangeEnd = 139386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_LocationBasedAction.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003699 RID: 13977 RVA: 0x00120B10 File Offset: 0x0011ED10
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_LocationBasedAction.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600369A RID: 13978 RVA: 0x00120B4C File Offset: 0x0011ED4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139386, XrefRangeEnd = 139404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_StartAction_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_LocationBasedAction.NativeMethodInfoPtr_RpcWriter___Observers_StartAction_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600369B RID: 13979 RVA: 0x00120B90 File Offset: 0x0011ED90
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 139407, RefRangeEnd = 139410, XrefRangeStart = 139404, XrefRangeEnd = 139407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___StartAction_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_LocationBasedAction.NativeMethodInfoPtr_RpcLogic___StartAction_328543758_Protected_Virtual_New_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600369C RID: 13980 RVA: 0x00120BE0 File Offset: 0x0011EDE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139410, XrefRangeEnd = 139413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_StartAction_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_LocationBasedAction.NativeMethodInfoPtr_RpcReader___Observers_StartAction_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600369D RID: 13981 RVA: 0x00120C30 File Offset: 0x0011EE30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139413, XrefRangeEnd = 139431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_StartAction_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_LocationBasedAction.NativeMethodInfoPtr_RpcWriter___Target_StartAction_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600369E RID: 13982 RVA: 0x00120C74 File Offset: 0x0011EE74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139431, XrefRangeEnd = 139434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_StartAction_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_LocationBasedAction.NativeMethodInfoPtr_RpcReader___Target_StartAction_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600369F RID: 13983 RVA: 0x00120CC4 File Offset: 0x0011EEC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139434, XrefRangeEnd = 139452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_EndAction_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_LocationBasedAction.NativeMethodInfoPtr_RpcWriter___Observers_EndAction_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036A0 RID: 13984 RVA: 0x00120CF8 File Offset: 0x0011EEF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139452, XrefRangeEnd = 139453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___EndAction_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_LocationBasedAction.NativeMethodInfoPtr_RpcLogic___EndAction_2166136261_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036A1 RID: 13985 RVA: 0x00120D34 File Offset: 0x0011EF34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139453, XrefRangeEnd = 139456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_EndAction_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_LocationBasedAction.NativeMethodInfoPtr_RpcReader___Observers_EndAction_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036A2 RID: 13986 RVA: 0x00120D84 File Offset: 0x0011EF84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_LocationBasedAction.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036A3 RID: 13987 RVA: 0x0001C8A7 File Offset: 0x0001AAA7
		public NPCEvent_LocationBasedAction(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700118E RID: 4494
		// (get) Token: 0x060036A4 RID: 13988 RVA: 0x00120DC0 File Offset: 0x0011EFC0
		// (set) Token: 0x060036A5 RID: 13989 RVA: 0x0001C8B0 File Offset: 0x0001AAB0
		public unsafe Transform Destination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_LocationBasedAction.NativeFieldInfoPtr_Destination);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_LocationBasedAction.NativeFieldInfoPtr_Destination), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700118F RID: 4495
		// (get) Token: 0x060036A6 RID: 13990 RVA: 0x00120DF0 File Offset: 0x0011EFF0
		// (set) Token: 0x060036A7 RID: 13991 RVA: 0x0001C8CF File Offset: 0x0001AACF
		public unsafe bool FaceDestinationDir
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_LocationBasedAction.NativeFieldInfoPtr_FaceDestinationDir);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_LocationBasedAction.NativeFieldInfoPtr_FaceDestinationDir)) = value;
			}
		}

		// Token: 0x17001190 RID: 4496
		// (get) Token: 0x060036A8 RID: 13992 RVA: 0x00120E18 File Offset: 0x0011F018
		// (set) Token: 0x060036A9 RID: 13993 RVA: 0x0001C8EA File Offset: 0x0001AAEA
		public unsafe float DestinationThreshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_LocationBasedAction.NativeFieldInfoPtr_DestinationThreshold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_LocationBasedAction.NativeFieldInfoPtr_DestinationThreshold)) = value;
			}
		}

		// Token: 0x17001191 RID: 4497
		// (get) Token: 0x060036AA RID: 13994 RVA: 0x00120E40 File Offset: 0x0011F040
		// (set) Token: 0x060036AB RID: 13995 RVA: 0x0001C905 File Offset: 0x0001AB05
		public unsafe bool WarpIfSkipped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_LocationBasedAction.NativeFieldInfoPtr_WarpIfSkipped);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_LocationBasedAction.NativeFieldInfoPtr_WarpIfSkipped)) = value;
			}
		}

		// Token: 0x17001192 RID: 4498
		// (get) Token: 0x060036AC RID: 13996 RVA: 0x00120E68 File Offset: 0x0011F068
		// (set) Token: 0x060036AD RID: 13997 RVA: 0x0001C920 File Offset: 0x0001AB20
		public unsafe bool IsActionStarted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_LocationBasedAction.NativeFieldInfoPtr_IsActionStarted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_LocationBasedAction.NativeFieldInfoPtr_IsActionStarted)) = value;
			}
		}

		// Token: 0x17001193 RID: 4499
		// (get) Token: 0x060036AE RID: 13998 RVA: 0x00120E90 File Offset: 0x0011F090
		// (set) Token: 0x060036AF RID: 13999 RVA: 0x0001C93B File Offset: 0x0001AB3B
		public unsafe UnityEvent onStartAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_LocationBasedAction.NativeFieldInfoPtr_onStartAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_LocationBasedAction.NativeFieldInfoPtr_onStartAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001194 RID: 4500
		// (get) Token: 0x060036B0 RID: 14000 RVA: 0x00120EC0 File Offset: 0x0011F0C0
		// (set) Token: 0x060036B1 RID: 14001 RVA: 0x0001C95A File Offset: 0x0001AB5A
		public unsafe UnityEvent onEndAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_LocationBasedAction.NativeFieldInfoPtr_onEndAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_LocationBasedAction.NativeFieldInfoPtr_onEndAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001195 RID: 4501
		// (get) Token: 0x060036B2 RID: 14002 RVA: 0x00120EF0 File Offset: 0x0011F0F0
		// (set) Token: 0x060036B3 RID: 14003 RVA: 0x0001C979 File Offset: 0x0001AB79
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_LocationBasedAction.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_LocationBasedAction.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001196 RID: 4502
		// (get) Token: 0x060036B4 RID: 14004 RVA: 0x00120F18 File Offset: 0x0011F118
		// (set) Token: 0x060036B5 RID: 14005 RVA: 0x0001C994 File Offset: 0x0001AB94
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_LocationBasedAction.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_LocationBasedAction.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040023B6 RID: 9142
		private static readonly IntPtr NativeFieldInfoPtr_Destination;

		// Token: 0x040023B7 RID: 9143
		private static readonly IntPtr NativeFieldInfoPtr_FaceDestinationDir;

		// Token: 0x040023B8 RID: 9144
		private static readonly IntPtr NativeFieldInfoPtr_DestinationThreshold;

		// Token: 0x040023B9 RID: 9145
		private static readonly IntPtr NativeFieldInfoPtr_WarpIfSkipped;

		// Token: 0x040023BA RID: 9146
		private static readonly IntPtr NativeFieldInfoPtr_IsActionStarted;

		// Token: 0x040023BB RID: 9147
		private static readonly IntPtr NativeFieldInfoPtr_onStartAction;

		// Token: 0x040023BC RID: 9148
		private static readonly IntPtr NativeFieldInfoPtr_onEndAction;

		// Token: 0x040023BD RID: 9149
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040023BE RID: 9150
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040023BF RID: 9151
		private static readonly IntPtr NativeMethodInfoPtr_get_ActionName_Public_get_String_0;

		// Token: 0x040023C0 RID: 9152
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_Virtual_String_0;

		// Token: 0x040023C1 RID: 9153
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x040023C2 RID: 9154
		private static readonly IntPtr NativeMethodInfoPtr_Started_Public_Virtual_Void_0;

		// Token: 0x040023C3 RID: 9155
		private static readonly IntPtr NativeMethodInfoPtr_ActiveMinPassed_Public_Virtual_Void_0;

		// Token: 0x040023C4 RID: 9156
		private static readonly IntPtr NativeMethodInfoPtr_LateStarted_Public_Virtual_Void_0;

		// Token: 0x040023C5 RID: 9157
		private static readonly IntPtr NativeMethodInfoPtr_JumpTo_Public_Virtual_Void_0;

		// Token: 0x040023C6 RID: 9158
		private static readonly IntPtr NativeMethodInfoPtr_End_Public_Virtual_Void_0;

		// Token: 0x040023C7 RID: 9159
		private static readonly IntPtr NativeMethodInfoPtr_Interrupt_Public_Virtual_Void_0;

		// Token: 0x040023C8 RID: 9160
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Public_Virtual_Void_0;

		// Token: 0x040023C9 RID: 9161
		private static readonly IntPtr NativeMethodInfoPtr_Skipped_Public_Virtual_Void_0;

		// Token: 0x040023CA RID: 9162
		private static readonly IntPtr NativeMethodInfoPtr_IsAtDestination_Private_Boolean_0;

		// Token: 0x040023CB RID: 9163
		private static readonly IntPtr NativeMethodInfoPtr_WalkCallback_Protected_Virtual_Void_WalkResult_0;

		// Token: 0x040023CC RID: 9164
		private static readonly IntPtr NativeMethodInfoPtr_StartAction_Protected_Virtual_New_Void_NetworkConnection_0;

		// Token: 0x040023CD RID: 9165
		private static readonly IntPtr NativeMethodInfoPtr_EndAction_Protected_Virtual_New_Void_0;

		// Token: 0x040023CE RID: 9166
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040023CF RID: 9167
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040023D0 RID: 9168
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040023D1 RID: 9169
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040023D2 RID: 9170
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_StartAction_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x040023D3 RID: 9171
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___StartAction_328543758_Protected_Virtual_New_Void_NetworkConnection_0;

		// Token: 0x040023D4 RID: 9172
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_StartAction_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x040023D5 RID: 9173
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_StartAction_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x040023D6 RID: 9174
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_StartAction_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x040023D7 RID: 9175
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_EndAction_2166136261_Private_Void_0;

		// Token: 0x040023D8 RID: 9176
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___EndAction_2166136261_Protected_Virtual_New_Void_0;

		// Token: 0x040023D9 RID: 9177
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_EndAction_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x040023DA RID: 9178
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
