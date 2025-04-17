using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Dialogue;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Schedules
{
	// Token: 0x020002E0 RID: 736
	public class NPCEvent_LocationDialogue : NPCEvent
	{
		// Token: 0x060036B6 RID: 14006 RVA: 0x00120F40 File Offset: 0x0011F140
		// Note: this type is marked as 'beforefieldinit'.
		static NPCEvent_LocationDialogue()
		{
			Il2CppClassPointerStore<NPCEvent_LocationDialogue>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Schedules", "NPCEvent_LocationDialogue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCEvent_LocationDialogue>.NativeClassPtr);
			NPCEvent_LocationDialogue.NativeFieldInfoPtr_Destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_LocationDialogue>.NativeClassPtr, "Destination");
			NPCEvent_LocationDialogue.NativeFieldInfoPtr_FaceDestinationDir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_LocationDialogue>.NativeClassPtr, "FaceDestinationDir");
			NPCEvent_LocationDialogue.NativeFieldInfoPtr_DestinationThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_LocationDialogue>.NativeClassPtr, "DestinationThreshold");
			NPCEvent_LocationDialogue.NativeFieldInfoPtr_WarpIfSkipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_LocationDialogue>.NativeClassPtr, "WarpIfSkipped");
			NPCEvent_LocationDialogue.NativeFieldInfoPtr_GreetingOverrideToEnable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_LocationDialogue>.NativeClassPtr, "GreetingOverrideToEnable");
			NPCEvent_LocationDialogue.NativeFieldInfoPtr_ChoiceToEnable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_LocationDialogue>.NativeClassPtr, "ChoiceToEnable");
			NPCEvent_LocationDialogue.NativeFieldInfoPtr_DialogueOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_LocationDialogue>.NativeClassPtr, "DialogueOverride");
			NPCEvent_LocationDialogue.NativeFieldInfoPtr_IsActionStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_LocationDialogue>.NativeClassPtr, "IsActionStarted");
			NPCEvent_LocationDialogue.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_LocationDialogue>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCEvent_LocationDialogueAssembly-CSharp.dll_Excuted");
			NPCEvent_LocationDialogue.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_LocationDialogue>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCEvent_LocationDialogueAssembly-CSharp.dll_Excuted");
			NPCEvent_LocationDialogue.NativeMethodInfoPtr_get_ActionName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_LocationDialogue>.NativeClassPtr, 100669550);
			NPCEvent_LocationDialogue.NativeMethodInfoPtr_GetName_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_LocationDialogue>.NativeClassPtr, 100669551);
			NPCEvent_LocationDialogue.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_LocationDialogue>.NativeClassPtr, 100669552);
			NPCEvent_LocationDialogue.NativeMethodInfoPtr_Started_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_LocationDialogue>.NativeClassPtr, 100669553);
			NPCEvent_LocationDialogue.NativeMethodInfoPtr_ActiveMinPassed_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_LocationDialogue>.NativeClassPtr, 100669554);
			NPCEvent_LocationDialogue.NativeMethodInfoPtr_LateStarted_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_LocationDialogue>.NativeClassPtr, 100669555);
			NPCEvent_LocationDialogue.NativeMethodInfoPtr_JumpTo_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_LocationDialogue>.NativeClassPtr, 100669556);
			NPCEvent_LocationDialogue.NativeMethodInfoPtr_End_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_LocationDialogue>.NativeClassPtr, 100669557);
			NPCEvent_LocationDialogue.NativeMethodInfoPtr_Interrupt_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_LocationDialogue>.NativeClassPtr, 100669558);
			NPCEvent_LocationDialogue.NativeMethodInfoPtr_Resume_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_LocationDialogue>.NativeClassPtr, 100669559);
			NPCEvent_LocationDialogue.NativeMethodInfoPtr_Skipped_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_LocationDialogue>.NativeClassPtr, 100669560);
			NPCEvent_LocationDialogue.NativeMethodInfoPtr_IsAtDestination_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_LocationDialogue>.NativeClassPtr, 100669561);
			NPCEvent_LocationDialogue.NativeMethodInfoPtr_WalkCallback_Protected_Virtual_Void_WalkResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_LocationDialogue>.NativeClassPtr, 100669562);
			NPCEvent_LocationDialogue.NativeMethodInfoPtr_StartAction_Protected_Virtual_New_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_LocationDialogue>.NativeClassPtr, 100669563);
			NPCEvent_LocationDialogue.NativeMethodInfoPtr_EndAction_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_LocationDialogue>.NativeClassPtr, 100669564);
			NPCEvent_LocationDialogue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_LocationDialogue>.NativeClassPtr, 100669565);
			NPCEvent_LocationDialogue.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_LocationDialogue>.NativeClassPtr, 100669566);
			NPCEvent_LocationDialogue.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_LocationDialogue>.NativeClassPtr, 100669567);
			NPCEvent_LocationDialogue.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_LocationDialogue>.NativeClassPtr, 100669568);
			NPCEvent_LocationDialogue.NativeMethodInfoPtr_RpcWriter___Observers_StartAction_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_LocationDialogue>.NativeClassPtr, 100669569);
			NPCEvent_LocationDialogue.NativeMethodInfoPtr_RpcLogic___StartAction_328543758_Protected_Virtual_New_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_LocationDialogue>.NativeClassPtr, 100669570);
			NPCEvent_LocationDialogue.NativeMethodInfoPtr_RpcReader___Observers_StartAction_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_LocationDialogue>.NativeClassPtr, 100669571);
			NPCEvent_LocationDialogue.NativeMethodInfoPtr_RpcWriter___Target_StartAction_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_LocationDialogue>.NativeClassPtr, 100669572);
			NPCEvent_LocationDialogue.NativeMethodInfoPtr_RpcReader___Target_StartAction_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_LocationDialogue>.NativeClassPtr, 100669573);
			NPCEvent_LocationDialogue.NativeMethodInfoPtr_RpcWriter___Observers_EndAction_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_LocationDialogue>.NativeClassPtr, 100669574);
			NPCEvent_LocationDialogue.NativeMethodInfoPtr_RpcLogic___EndAction_2166136261_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_LocationDialogue>.NativeClassPtr, 100669575);
			NPCEvent_LocationDialogue.NativeMethodInfoPtr_RpcReader___Observers_EndAction_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_LocationDialogue>.NativeClassPtr, 100669576);
			NPCEvent_LocationDialogue.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_LocationDialogue>.NativeClassPtr, 100669577);
		}

		// Token: 0x170011A2 RID: 4514
		// (get) Token: 0x060036B7 RID: 14007 RVA: 0x00121268 File Offset: 0x0011F468
		public new unsafe string ActionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139456, XrefRangeEnd = 139458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_LocationDialogue.NativeMethodInfoPtr_get_ActionName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060036B8 RID: 14008 RVA: 0x001212A0 File Offset: 0x0011F4A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139458, XrefRangeEnd = 139472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_LocationDialogue.NativeMethodInfoPtr_GetName_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060036B9 RID: 14009 RVA: 0x001212E4 File Offset: 0x0011F4E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139472, XrefRangeEnd = 139473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_LocationDialogue.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036BA RID: 14010 RVA: 0x00121334 File Offset: 0x0011F534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Started()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_LocationDialogue.NativeMethodInfoPtr_Started_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036BB RID: 14011 RVA: 0x00121370 File Offset: 0x0011F570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139473, XrefRangeEnd = 139479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ActiveMinPassed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_LocationDialogue.NativeMethodInfoPtr_ActiveMinPassed_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036BC RID: 14012 RVA: 0x001213AC File Offset: 0x0011F5AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void LateStarted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_LocationDialogue.NativeMethodInfoPtr_LateStarted_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036BD RID: 14013 RVA: 0x001213E8 File Offset: 0x0011F5E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139479, XrefRangeEnd = 139487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void JumpTo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_LocationDialogue.NativeMethodInfoPtr_JumpTo_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036BE RID: 14014 RVA: 0x00121424 File Offset: 0x0011F624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139487, XrefRangeEnd = 139488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_LocationDialogue.NativeMethodInfoPtr_End_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036BF RID: 14015 RVA: 0x00121460 File Offset: 0x0011F660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139488, XrefRangeEnd = 139493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Interrupt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_LocationDialogue.NativeMethodInfoPtr_Interrupt_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036C0 RID: 14016 RVA: 0x0012149C File Offset: 0x0011F69C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_LocationDialogue.NativeMethodInfoPtr_Resume_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036C1 RID: 14017 RVA: 0x001214D8 File Offset: 0x0011F6D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Skipped()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_LocationDialogue.NativeMethodInfoPtr_Skipped_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036C2 RID: 14018 RVA: 0x00121514 File Offset: 0x0011F714
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 139295, RefRangeEnd = 139305, XrefRangeStart = 139295, XrefRangeEnd = 139305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAtDestination()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_LocationDialogue.NativeMethodInfoPtr_IsAtDestination_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060036C3 RID: 14019 RVA: 0x00121550 File Offset: 0x0011F750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WalkCallback(NPCMovement.WalkResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_LocationDialogue.NativeMethodInfoPtr_WalkCallback_Protected_Virtual_Void_WalkResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036C4 RID: 14020 RVA: 0x0012159C File Offset: 0x0011F79C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139493, XrefRangeEnd = 139530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StartAction(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_LocationDialogue.NativeMethodInfoPtr_StartAction_Protected_Virtual_New_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036C5 RID: 14021 RVA: 0x001215EC File Offset: 0x0011F7EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139530, XrefRangeEnd = 139551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void EndAction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_LocationDialogue.NativeMethodInfoPtr_EndAction_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036C6 RID: 14022 RVA: 0x00121628 File Offset: 0x0011F828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139551, XrefRangeEnd = 139552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCEvent_LocationDialogue() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCEvent_LocationDialogue>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_LocationDialogue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036C7 RID: 14023 RVA: 0x00121664 File Offset: 0x0011F864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139552, XrefRangeEnd = 139572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_LocationDialogue.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036C8 RID: 14024 RVA: 0x001216A0 File Offset: 0x0011F8A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139572, XrefRangeEnd = 139573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_LocationDialogue.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036C9 RID: 14025 RVA: 0x001216DC File Offset: 0x0011F8DC
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_LocationDialogue.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036CA RID: 14026 RVA: 0x00121718 File Offset: 0x0011F918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139573, XrefRangeEnd = 139591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_StartAction_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_LocationDialogue.NativeMethodInfoPtr_RpcWriter___Observers_StartAction_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036CB RID: 14027 RVA: 0x0012175C File Offset: 0x0011F95C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 139611, RefRangeEnd = 139614, XrefRangeStart = 139591, XrefRangeEnd = 139611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___StartAction_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_LocationDialogue.NativeMethodInfoPtr_RpcLogic___StartAction_328543758_Protected_Virtual_New_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036CC RID: 14028 RVA: 0x001217AC File Offset: 0x0011F9AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139614, XrefRangeEnd = 139617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_StartAction_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_LocationDialogue.NativeMethodInfoPtr_RpcReader___Observers_StartAction_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036CD RID: 14029 RVA: 0x001217FC File Offset: 0x0011F9FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139617, XrefRangeEnd = 139635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_StartAction_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_LocationDialogue.NativeMethodInfoPtr_RpcWriter___Target_StartAction_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036CE RID: 14030 RVA: 0x00121840 File Offset: 0x0011FA40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139635, XrefRangeEnd = 139638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_StartAction_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_LocationDialogue.NativeMethodInfoPtr_RpcReader___Target_StartAction_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036CF RID: 14031 RVA: 0x00121890 File Offset: 0x0011FA90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139638, XrefRangeEnd = 139656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_EndAction_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_LocationDialogue.NativeMethodInfoPtr_RpcWriter___Observers_EndAction_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036D0 RID: 14032 RVA: 0x001218C4 File Offset: 0x0011FAC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 139671, RefRangeEnd = 139673, XrefRangeStart = 139656, XrefRangeEnd = 139671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___EndAction_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_LocationDialogue.NativeMethodInfoPtr_RpcLogic___EndAction_2166136261_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036D1 RID: 14033 RVA: 0x00121900 File Offset: 0x0011FB00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139673, XrefRangeEnd = 139676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_EndAction_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_LocationDialogue.NativeMethodInfoPtr_RpcReader___Observers_EndAction_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036D2 RID: 14034 RVA: 0x00121950 File Offset: 0x0011FB50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_LocationDialogue.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036D3 RID: 14035 RVA: 0x0001C9AF File Offset: 0x0001ABAF
		public NPCEvent_LocationDialogue(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001198 RID: 4504
		// (get) Token: 0x060036D4 RID: 14036 RVA: 0x0012198C File Offset: 0x0011FB8C
		// (set) Token: 0x060036D5 RID: 14037 RVA: 0x0001C9B8 File Offset: 0x0001ABB8
		public unsafe Transform Destination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_LocationDialogue.NativeFieldInfoPtr_Destination);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_LocationDialogue.NativeFieldInfoPtr_Destination), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001199 RID: 4505
		// (get) Token: 0x060036D6 RID: 14038 RVA: 0x001219BC File Offset: 0x0011FBBC
		// (set) Token: 0x060036D7 RID: 14039 RVA: 0x0001C9D7 File Offset: 0x0001ABD7
		public unsafe bool FaceDestinationDir
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_LocationDialogue.NativeFieldInfoPtr_FaceDestinationDir);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_LocationDialogue.NativeFieldInfoPtr_FaceDestinationDir)) = value;
			}
		}

		// Token: 0x1700119A RID: 4506
		// (get) Token: 0x060036D8 RID: 14040 RVA: 0x001219E4 File Offset: 0x0011FBE4
		// (set) Token: 0x060036D9 RID: 14041 RVA: 0x0001C9F2 File Offset: 0x0001ABF2
		public unsafe float DestinationThreshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_LocationDialogue.NativeFieldInfoPtr_DestinationThreshold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_LocationDialogue.NativeFieldInfoPtr_DestinationThreshold)) = value;
			}
		}

		// Token: 0x1700119B RID: 4507
		// (get) Token: 0x060036DA RID: 14042 RVA: 0x00121A0C File Offset: 0x0011FC0C
		// (set) Token: 0x060036DB RID: 14043 RVA: 0x0001CA0D File Offset: 0x0001AC0D
		public unsafe bool WarpIfSkipped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_LocationDialogue.NativeFieldInfoPtr_WarpIfSkipped);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_LocationDialogue.NativeFieldInfoPtr_WarpIfSkipped)) = value;
			}
		}

		// Token: 0x1700119C RID: 4508
		// (get) Token: 0x060036DC RID: 14044 RVA: 0x00121A34 File Offset: 0x0011FC34
		// (set) Token: 0x060036DD RID: 14045 RVA: 0x0001CA28 File Offset: 0x0001AC28
		public unsafe int GreetingOverrideToEnable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_LocationDialogue.NativeFieldInfoPtr_GreetingOverrideToEnable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_LocationDialogue.NativeFieldInfoPtr_GreetingOverrideToEnable)) = value;
			}
		}

		// Token: 0x1700119D RID: 4509
		// (get) Token: 0x060036DE RID: 14046 RVA: 0x00121A5C File Offset: 0x0011FC5C
		// (set) Token: 0x060036DF RID: 14047 RVA: 0x0001CA43 File Offset: 0x0001AC43
		public unsafe int ChoiceToEnable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_LocationDialogue.NativeFieldInfoPtr_ChoiceToEnable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_LocationDialogue.NativeFieldInfoPtr_ChoiceToEnable)) = value;
			}
		}

		// Token: 0x1700119E RID: 4510
		// (get) Token: 0x060036E0 RID: 14048 RVA: 0x00121A84 File Offset: 0x0011FC84
		// (set) Token: 0x060036E1 RID: 14049 RVA: 0x0001CA5E File Offset: 0x0001AC5E
		public unsafe DialogueContainer DialogueOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_LocationDialogue.NativeFieldInfoPtr_DialogueOverride);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_LocationDialogue.NativeFieldInfoPtr_DialogueOverride), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700119F RID: 4511
		// (get) Token: 0x060036E2 RID: 14050 RVA: 0x00121AB4 File Offset: 0x0011FCB4
		// (set) Token: 0x060036E3 RID: 14051 RVA: 0x0001CA7D File Offset: 0x0001AC7D
		public unsafe bool IsActionStarted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_LocationDialogue.NativeFieldInfoPtr_IsActionStarted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_LocationDialogue.NativeFieldInfoPtr_IsActionStarted)) = value;
			}
		}

		// Token: 0x170011A0 RID: 4512
		// (get) Token: 0x060036E4 RID: 14052 RVA: 0x00121ADC File Offset: 0x0011FCDC
		// (set) Token: 0x060036E5 RID: 14053 RVA: 0x0001CA98 File Offset: 0x0001AC98
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_LocationDialogue.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_LocationDialogue.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170011A1 RID: 4513
		// (get) Token: 0x060036E6 RID: 14054 RVA: 0x00121B04 File Offset: 0x0011FD04
		// (set) Token: 0x060036E7 RID: 14055 RVA: 0x0001CAB3 File Offset: 0x0001ACB3
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_LocationDialogue.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_LocationDialogue.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040023DB RID: 9179
		private static readonly IntPtr NativeFieldInfoPtr_Destination;

		// Token: 0x040023DC RID: 9180
		private static readonly IntPtr NativeFieldInfoPtr_FaceDestinationDir;

		// Token: 0x040023DD RID: 9181
		private static readonly IntPtr NativeFieldInfoPtr_DestinationThreshold;

		// Token: 0x040023DE RID: 9182
		private static readonly IntPtr NativeFieldInfoPtr_WarpIfSkipped;

		// Token: 0x040023DF RID: 9183
		private static readonly IntPtr NativeFieldInfoPtr_GreetingOverrideToEnable;

		// Token: 0x040023E0 RID: 9184
		private static readonly IntPtr NativeFieldInfoPtr_ChoiceToEnable;

		// Token: 0x040023E1 RID: 9185
		private static readonly IntPtr NativeFieldInfoPtr_DialogueOverride;

		// Token: 0x040023E2 RID: 9186
		private static readonly IntPtr NativeFieldInfoPtr_IsActionStarted;

		// Token: 0x040023E3 RID: 9187
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040023E4 RID: 9188
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040023E5 RID: 9189
		private static readonly IntPtr NativeMethodInfoPtr_get_ActionName_Public_get_String_0;

		// Token: 0x040023E6 RID: 9190
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_Virtual_String_0;

		// Token: 0x040023E7 RID: 9191
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x040023E8 RID: 9192
		private static readonly IntPtr NativeMethodInfoPtr_Started_Public_Virtual_Void_0;

		// Token: 0x040023E9 RID: 9193
		private static readonly IntPtr NativeMethodInfoPtr_ActiveMinPassed_Public_Virtual_Void_0;

		// Token: 0x040023EA RID: 9194
		private static readonly IntPtr NativeMethodInfoPtr_LateStarted_Public_Virtual_Void_0;

		// Token: 0x040023EB RID: 9195
		private static readonly IntPtr NativeMethodInfoPtr_JumpTo_Public_Virtual_Void_0;

		// Token: 0x040023EC RID: 9196
		private static readonly IntPtr NativeMethodInfoPtr_End_Public_Virtual_Void_0;

		// Token: 0x040023ED RID: 9197
		private static readonly IntPtr NativeMethodInfoPtr_Interrupt_Public_Virtual_Void_0;

		// Token: 0x040023EE RID: 9198
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Public_Virtual_Void_0;

		// Token: 0x040023EF RID: 9199
		private static readonly IntPtr NativeMethodInfoPtr_Skipped_Public_Virtual_Void_0;

		// Token: 0x040023F0 RID: 9200
		private static readonly IntPtr NativeMethodInfoPtr_IsAtDestination_Private_Boolean_0;

		// Token: 0x040023F1 RID: 9201
		private static readonly IntPtr NativeMethodInfoPtr_WalkCallback_Protected_Virtual_Void_WalkResult_0;

		// Token: 0x040023F2 RID: 9202
		private static readonly IntPtr NativeMethodInfoPtr_StartAction_Protected_Virtual_New_Void_NetworkConnection_0;

		// Token: 0x040023F3 RID: 9203
		private static readonly IntPtr NativeMethodInfoPtr_EndAction_Protected_Virtual_New_Void_0;

		// Token: 0x040023F4 RID: 9204
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040023F5 RID: 9205
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040023F6 RID: 9206
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040023F7 RID: 9207
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040023F8 RID: 9208
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_StartAction_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x040023F9 RID: 9209
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___StartAction_328543758_Protected_Virtual_New_Void_NetworkConnection_0;

		// Token: 0x040023FA RID: 9210
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_StartAction_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x040023FB RID: 9211
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_StartAction_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x040023FC RID: 9212
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_StartAction_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x040023FD RID: 9213
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_EndAction_2166136261_Private_Void_0;

		// Token: 0x040023FE RID: 9214
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___EndAction_2166136261_Protected_Virtual_New_Void_0;

		// Token: 0x040023FF RID: 9215
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_EndAction_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002400 RID: 9216
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
