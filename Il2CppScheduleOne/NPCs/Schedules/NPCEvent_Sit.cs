using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework.Animation;
using UnityEngine.Events;

namespace Il2CppScheduleOne.NPCs.Schedules
{
	// Token: 0x020002E1 RID: 737
	public class NPCEvent_Sit : NPCEvent
	{
		// Token: 0x060036E8 RID: 14056 RVA: 0x00121B2C File Offset: 0x0011FD2C
		// Note: this type is marked as 'beforefieldinit'.
		static NPCEvent_Sit()
		{
			Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Schedules", "NPCEvent_Sit");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr);
			NPCEvent_Sit.NativeFieldInfoPtr_DESTINATION_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, "DESTINATION_THRESHOLD");
			NPCEvent_Sit.NativeFieldInfoPtr_SeatSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, "SeatSet");
			NPCEvent_Sit.NativeFieldInfoPtr_WarpIfSkipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, "WarpIfSkipped");
			NPCEvent_Sit.NativeFieldInfoPtr_seated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, "seated");
			NPCEvent_Sit.NativeFieldInfoPtr_targetSeat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, "targetSeat");
			NPCEvent_Sit.NativeFieldInfoPtr_onSeated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, "onSeated");
			NPCEvent_Sit.NativeFieldInfoPtr_onStandUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, "onStandUp");
			NPCEvent_Sit.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCEvent_SitAssembly-CSharp.dll_Excuted");
			NPCEvent_Sit.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCEvent_SitAssembly-CSharp.dll_Excuted");
			NPCEvent_Sit.NativeMethodInfoPtr_get_ActionName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, 100669578);
			NPCEvent_Sit.NativeMethodInfoPtr_GetName_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, 100669579);
			NPCEvent_Sit.NativeMethodInfoPtr_Started_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, 100669580);
			NPCEvent_Sit.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, 100669581);
			NPCEvent_Sit.NativeMethodInfoPtr_LateStarted_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, 100669582);
			NPCEvent_Sit.NativeMethodInfoPtr_ActiveMinPassed_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, 100669583);
			NPCEvent_Sit.NativeMethodInfoPtr_JumpTo_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, 100669584);
			NPCEvent_Sit.NativeMethodInfoPtr_End_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, 100669585);
			NPCEvent_Sit.NativeMethodInfoPtr_Interrupt_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, 100669586);
			NPCEvent_Sit.NativeMethodInfoPtr_Resume_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, 100669587);
			NPCEvent_Sit.NativeMethodInfoPtr_Skipped_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, 100669588);
			NPCEvent_Sit.NativeMethodInfoPtr_IsAtDestination_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, 100669589);
			NPCEvent_Sit.NativeMethodInfoPtr_WalkCallback_Protected_Virtual_Void_WalkResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, 100669590);
			NPCEvent_Sit.NativeMethodInfoPtr_StartAction_Protected_Virtual_New_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, 100669591);
			NPCEvent_Sit.NativeMethodInfoPtr_EndAction_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, 100669592);
			NPCEvent_Sit.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, 100669593);
			NPCEvent_Sit.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, 100669594);
			NPCEvent_Sit.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, 100669595);
			NPCEvent_Sit.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, 100669596);
			NPCEvent_Sit.NativeMethodInfoPtr_RpcWriter___Observers_StartAction_2681120339_Private_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, 100669597);
			NPCEvent_Sit.NativeMethodInfoPtr_RpcLogic___StartAction_2681120339_Protected_Virtual_New_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, 100669598);
			NPCEvent_Sit.NativeMethodInfoPtr_RpcReader___Observers_StartAction_2681120339_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, 100669599);
			NPCEvent_Sit.NativeMethodInfoPtr_RpcWriter___Target_StartAction_2681120339_Private_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, 100669600);
			NPCEvent_Sit.NativeMethodInfoPtr_RpcReader___Target_StartAction_2681120339_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, 100669601);
			NPCEvent_Sit.NativeMethodInfoPtr_RpcWriter___Observers_EndAction_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, 100669602);
			NPCEvent_Sit.NativeMethodInfoPtr_RpcLogic___EndAction_2166136261_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, 100669603);
			NPCEvent_Sit.NativeMethodInfoPtr_RpcReader___Observers_EndAction_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, 100669604);
			NPCEvent_Sit.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr, 100669605);
		}

		// Token: 0x170011AC RID: 4524
		// (get) Token: 0x060036E9 RID: 14057 RVA: 0x00121E40 File Offset: 0x00120040
		public new unsafe string ActionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139676, XrefRangeEnd = 139678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_Sit.NativeMethodInfoPtr_get_ActionName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060036EA RID: 14058 RVA: 0x00121E78 File Offset: 0x00120078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139678, XrefRangeEnd = 139687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Sit.NativeMethodInfoPtr_GetName_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060036EB RID: 14059 RVA: 0x00121EBC File Offset: 0x001200BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139687, XrefRangeEnd = 139693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Started()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Sit.NativeMethodInfoPtr_Started_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036EC RID: 14060 RVA: 0x00121EF8 File Offset: 0x001200F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139693, XrefRangeEnd = 139697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Sit.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036ED RID: 14061 RVA: 0x00121F48 File Offset: 0x00120148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139697, XrefRangeEnd = 139703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void LateStarted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Sit.NativeMethodInfoPtr_LateStarted_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036EE RID: 14062 RVA: 0x00121F84 File Offset: 0x00120184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139703, XrefRangeEnd = 139736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ActiveMinPassed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Sit.NativeMethodInfoPtr_ActiveMinPassed_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036EF RID: 14063 RVA: 0x00121FC0 File Offset: 0x001201C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139736, XrefRangeEnd = 139751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void JumpTo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Sit.NativeMethodInfoPtr_JumpTo_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036F0 RID: 14064 RVA: 0x00121FFC File Offset: 0x001201FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139751, XrefRangeEnd = 139753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Sit.NativeMethodInfoPtr_End_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036F1 RID: 14065 RVA: 0x00122038 File Offset: 0x00120238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139753, XrefRangeEnd = 139757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Interrupt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Sit.NativeMethodInfoPtr_Interrupt_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036F2 RID: 14066 RVA: 0x00122074 File Offset: 0x00120274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139757, XrefRangeEnd = 139763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Sit.NativeMethodInfoPtr_Resume_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036F3 RID: 14067 RVA: 0x001220B0 File Offset: 0x001202B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139763, XrefRangeEnd = 139768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Skipped()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Sit.NativeMethodInfoPtr_Skipped_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036F4 RID: 14068 RVA: 0x001220EC File Offset: 0x001202EC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 139780, RefRangeEnd = 139786, XrefRangeStart = 139768, XrefRangeEnd = 139780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAtDestination()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_Sit.NativeMethodInfoPtr_IsAtDestination_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060036F5 RID: 14069 RVA: 0x00122128 File Offset: 0x00120328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139786, XrefRangeEnd = 139792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WalkCallback(NPCMovement.WalkResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Sit.NativeMethodInfoPtr_WalkCallback_Protected_Virtual_Void_WalkResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036F6 RID: 14070 RVA: 0x00122174 File Offset: 0x00120374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139792, XrefRangeEnd = 139836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StartAction(NetworkConnection conn, int seatIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seatIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Sit.NativeMethodInfoPtr_StartAction_Protected_Virtual_New_Void_NetworkConnection_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036F7 RID: 14071 RVA: 0x001221D0 File Offset: 0x001203D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139836, XrefRangeEnd = 139857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void EndAction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Sit.NativeMethodInfoPtr_EndAction_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036F8 RID: 14072 RVA: 0x0012220C File Offset: 0x0012040C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139857, XrefRangeEnd = 139858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCEvent_Sit() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCEvent_Sit>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_Sit.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036F9 RID: 14073 RVA: 0x00122248 File Offset: 0x00120448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139858, XrefRangeEnd = 139878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Sit.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036FA RID: 14074 RVA: 0x00122284 File Offset: 0x00120484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Sit.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036FB RID: 14075 RVA: 0x001222C0 File Offset: 0x001204C0
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Sit.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036FC RID: 14076 RVA: 0x001222FC File Offset: 0x001204FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139878, XrefRangeEnd = 139898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_StartAction_2681120339(NetworkConnection conn, int seatIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seatIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_Sit.NativeMethodInfoPtr_RpcWriter___Observers_StartAction_2681120339_Private_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036FD RID: 14077 RVA: 0x0012234C File Offset: 0x0012054C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 139902, RefRangeEnd = 139905, XrefRangeStart = 139898, XrefRangeEnd = 139902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___StartAction_2681120339(NetworkConnection conn, int seatIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seatIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Sit.NativeMethodInfoPtr_RpcLogic___StartAction_2681120339_Protected_Virtual_New_Void_NetworkConnection_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036FE RID: 14078 RVA: 0x001223A8 File Offset: 0x001205A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139905, XrefRangeEnd = 139910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_StartAction_2681120339(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_Sit.NativeMethodInfoPtr_RpcReader___Observers_StartAction_2681120339_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060036FF RID: 14079 RVA: 0x001223F8 File Offset: 0x001205F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139910, XrefRangeEnd = 139930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_StartAction_2681120339(NetworkConnection conn, int seatIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seatIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_Sit.NativeMethodInfoPtr_RpcWriter___Target_StartAction_2681120339_Private_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003700 RID: 14080 RVA: 0x00122448 File Offset: 0x00120648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139930, XrefRangeEnd = 139935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_StartAction_2681120339(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_Sit.NativeMethodInfoPtr_RpcReader___Target_StartAction_2681120339_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003701 RID: 14081 RVA: 0x00122498 File Offset: 0x00120698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139935, XrefRangeEnd = 139953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_EndAction_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_Sit.NativeMethodInfoPtr_RpcWriter___Observers_EndAction_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003702 RID: 14082 RVA: 0x001224CC File Offset: 0x001206CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 139955, RefRangeEnd = 139956, XrefRangeStart = 139953, XrefRangeEnd = 139955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___EndAction_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Sit.NativeMethodInfoPtr_RpcLogic___EndAction_2166136261_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003703 RID: 14083 RVA: 0x00122508 File Offset: 0x00120708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139956, XrefRangeEnd = 139959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_EndAction_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEvent_Sit.NativeMethodInfoPtr_RpcReader___Observers_EndAction_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003704 RID: 14084 RVA: 0x00122558 File Offset: 0x00120758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEvent_Sit.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003705 RID: 14085 RVA: 0x0001CACE File Offset: 0x0001ACCE
		public NPCEvent_Sit(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170011A3 RID: 4515
		// (get) Token: 0x06003706 RID: 14086 RVA: 0x00122594 File Offset: 0x00120794
		// (set) Token: 0x06003707 RID: 14087 RVA: 0x0001CAD7 File Offset: 0x0001ACD7
		public unsafe static float DESTINATION_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCEvent_Sit.NativeFieldInfoPtr_DESTINATION_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCEvent_Sit.NativeFieldInfoPtr_DESTINATION_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x170011A4 RID: 4516
		// (get) Token: 0x06003708 RID: 14088 RVA: 0x001225B0 File Offset: 0x001207B0
		// (set) Token: 0x06003709 RID: 14089 RVA: 0x0001CAE5 File Offset: 0x0001ACE5
		public unsafe AvatarSeatSet SeatSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Sit.NativeFieldInfoPtr_SeatSet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarSeatSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Sit.NativeFieldInfoPtr_SeatSet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011A5 RID: 4517
		// (get) Token: 0x0600370A RID: 14090 RVA: 0x001225E0 File Offset: 0x001207E0
		// (set) Token: 0x0600370B RID: 14091 RVA: 0x0001CB04 File Offset: 0x0001AD04
		public unsafe bool WarpIfSkipped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Sit.NativeFieldInfoPtr_WarpIfSkipped);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Sit.NativeFieldInfoPtr_WarpIfSkipped)) = value;
			}
		}

		// Token: 0x170011A6 RID: 4518
		// (get) Token: 0x0600370C RID: 14092 RVA: 0x00122608 File Offset: 0x00120808
		// (set) Token: 0x0600370D RID: 14093 RVA: 0x0001CB1F File Offset: 0x0001AD1F
		public unsafe bool seated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Sit.NativeFieldInfoPtr_seated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Sit.NativeFieldInfoPtr_seated)) = value;
			}
		}

		// Token: 0x170011A7 RID: 4519
		// (get) Token: 0x0600370E RID: 14094 RVA: 0x00122630 File Offset: 0x00120830
		// (set) Token: 0x0600370F RID: 14095 RVA: 0x0001CB3A File Offset: 0x0001AD3A
		public unsafe AvatarSeat targetSeat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Sit.NativeFieldInfoPtr_targetSeat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarSeat>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Sit.NativeFieldInfoPtr_targetSeat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011A8 RID: 4520
		// (get) Token: 0x06003710 RID: 14096 RVA: 0x00122660 File Offset: 0x00120860
		// (set) Token: 0x06003711 RID: 14097 RVA: 0x0001CB59 File Offset: 0x0001AD59
		public unsafe UnityEvent onSeated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Sit.NativeFieldInfoPtr_onSeated);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Sit.NativeFieldInfoPtr_onSeated), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011A9 RID: 4521
		// (get) Token: 0x06003712 RID: 14098 RVA: 0x00122690 File Offset: 0x00120890
		// (set) Token: 0x06003713 RID: 14099 RVA: 0x0001CB78 File Offset: 0x0001AD78
		public unsafe UnityEvent onStandUp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Sit.NativeFieldInfoPtr_onStandUp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Sit.NativeFieldInfoPtr_onStandUp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011AA RID: 4522
		// (get) Token: 0x06003714 RID: 14100 RVA: 0x001226C0 File Offset: 0x001208C0
		// (set) Token: 0x06003715 RID: 14101 RVA: 0x0001CB97 File Offset: 0x0001AD97
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Sit.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Sit.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170011AB RID: 4523
		// (get) Token: 0x06003716 RID: 14102 RVA: 0x001226E8 File Offset: 0x001208E8
		// (set) Token: 0x06003717 RID: 14103 RVA: 0x0001CBB2 File Offset: 0x0001ADB2
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Sit.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEvent_Sit.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002401 RID: 9217
		private static readonly IntPtr NativeFieldInfoPtr_DESTINATION_THRESHOLD;

		// Token: 0x04002402 RID: 9218
		private static readonly IntPtr NativeFieldInfoPtr_SeatSet;

		// Token: 0x04002403 RID: 9219
		private static readonly IntPtr NativeFieldInfoPtr_WarpIfSkipped;

		// Token: 0x04002404 RID: 9220
		private static readonly IntPtr NativeFieldInfoPtr_seated;

		// Token: 0x04002405 RID: 9221
		private static readonly IntPtr NativeFieldInfoPtr_targetSeat;

		// Token: 0x04002406 RID: 9222
		private static readonly IntPtr NativeFieldInfoPtr_onSeated;

		// Token: 0x04002407 RID: 9223
		private static readonly IntPtr NativeFieldInfoPtr_onStandUp;

		// Token: 0x04002408 RID: 9224
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002409 RID: 9225
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400240A RID: 9226
		private static readonly IntPtr NativeMethodInfoPtr_get_ActionName_Public_get_String_0;

		// Token: 0x0400240B RID: 9227
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_Virtual_String_0;

		// Token: 0x0400240C RID: 9228
		private static readonly IntPtr NativeMethodInfoPtr_Started_Public_Virtual_Void_0;

		// Token: 0x0400240D RID: 9229
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x0400240E RID: 9230
		private static readonly IntPtr NativeMethodInfoPtr_LateStarted_Public_Virtual_Void_0;

		// Token: 0x0400240F RID: 9231
		private static readonly IntPtr NativeMethodInfoPtr_ActiveMinPassed_Public_Virtual_Void_0;

		// Token: 0x04002410 RID: 9232
		private static readonly IntPtr NativeMethodInfoPtr_JumpTo_Public_Virtual_Void_0;

		// Token: 0x04002411 RID: 9233
		private static readonly IntPtr NativeMethodInfoPtr_End_Public_Virtual_Void_0;

		// Token: 0x04002412 RID: 9234
		private static readonly IntPtr NativeMethodInfoPtr_Interrupt_Public_Virtual_Void_0;

		// Token: 0x04002413 RID: 9235
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Public_Virtual_Void_0;

		// Token: 0x04002414 RID: 9236
		private static readonly IntPtr NativeMethodInfoPtr_Skipped_Public_Virtual_Void_0;

		// Token: 0x04002415 RID: 9237
		private static readonly IntPtr NativeMethodInfoPtr_IsAtDestination_Private_Boolean_0;

		// Token: 0x04002416 RID: 9238
		private static readonly IntPtr NativeMethodInfoPtr_WalkCallback_Protected_Virtual_Void_WalkResult_0;

		// Token: 0x04002417 RID: 9239
		private static readonly IntPtr NativeMethodInfoPtr_StartAction_Protected_Virtual_New_Void_NetworkConnection_Int32_0;

		// Token: 0x04002418 RID: 9240
		private static readonly IntPtr NativeMethodInfoPtr_EndAction_Protected_Virtual_New_Void_0;

		// Token: 0x04002419 RID: 9241
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400241A RID: 9242
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400241B RID: 9243
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400241C RID: 9244
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400241D RID: 9245
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_StartAction_2681120339_Private_Void_NetworkConnection_Int32_0;

		// Token: 0x0400241E RID: 9246
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___StartAction_2681120339_Protected_Virtual_New_Void_NetworkConnection_Int32_0;

		// Token: 0x0400241F RID: 9247
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_StartAction_2681120339_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002420 RID: 9248
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_StartAction_2681120339_Private_Void_NetworkConnection_Int32_0;

		// Token: 0x04002421 RID: 9249
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_StartAction_2681120339_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002422 RID: 9250
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_EndAction_2166136261_Private_Void_0;

		// Token: 0x04002423 RID: 9251
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___EndAction_2166136261_Protected_Virtual_New_Void_0;

		// Token: 0x04002424 RID: 9252
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_EndAction_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002425 RID: 9253
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
