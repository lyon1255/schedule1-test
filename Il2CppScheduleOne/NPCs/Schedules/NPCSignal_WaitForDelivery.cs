using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Economy;

namespace Il2CppScheduleOne.NPCs.Schedules
{
	// Token: 0x020002EB RID: 747
	public class NPCSignal_WaitForDelivery : NPCSignal
	{
		// Token: 0x06003850 RID: 14416 RVA: 0x001271AC File Offset: 0x001253AC
		// Note: this type is marked as 'beforefieldinit'.
		static NPCSignal_WaitForDelivery()
		{
			Il2CppClassPointerStore<NPCSignal_WaitForDelivery>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Schedules", "NPCSignal_WaitForDelivery");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCSignal_WaitForDelivery>.NativeClassPtr);
			NPCSignal_WaitForDelivery.NativeFieldInfoPtr_DESTINATION_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSignal_WaitForDelivery>.NativeClassPtr, "DESTINATION_THRESHOLD");
			NPCSignal_WaitForDelivery.NativeFieldInfoPtr_Location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSignal_WaitForDelivery>.NativeClassPtr, "Location");
			NPCSignal_WaitForDelivery.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSignal_WaitForDelivery>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCSignal_WaitForDeliveryAssembly-CSharp.dll_Excuted");
			NPCSignal_WaitForDelivery.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCSignal_WaitForDelivery>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCSignal_WaitForDeliveryAssembly-CSharp.dll_Excuted");
			NPCSignal_WaitForDelivery.NativeMethodInfoPtr_get_ActionName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_WaitForDelivery>.NativeClassPtr, 100669826);
			NPCSignal_WaitForDelivery.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_WaitForDelivery>.NativeClassPtr, 100669827);
			NPCSignal_WaitForDelivery.NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_WaitForDelivery>.NativeClassPtr, 100669828);
			NPCSignal_WaitForDelivery.NativeMethodInfoPtr_GetName_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_WaitForDelivery>.NativeClassPtr, 100669829);
			NPCSignal_WaitForDelivery.NativeMethodInfoPtr_Started_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_WaitForDelivery>.NativeClassPtr, 100669830);
			NPCSignal_WaitForDelivery.NativeMethodInfoPtr_ActiveMinPassed_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_WaitForDelivery>.NativeClassPtr, 100669831);
			NPCSignal_WaitForDelivery.NativeMethodInfoPtr_LateStarted_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_WaitForDelivery>.NativeClassPtr, 100669832);
			NPCSignal_WaitForDelivery.NativeMethodInfoPtr_JumpTo_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_WaitForDelivery>.NativeClassPtr, 100669833);
			NPCSignal_WaitForDelivery.NativeMethodInfoPtr_Interrupt_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_WaitForDelivery>.NativeClassPtr, 100669834);
			NPCSignal_WaitForDelivery.NativeMethodInfoPtr_Resume_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_WaitForDelivery>.NativeClassPtr, 100669835);
			NPCSignal_WaitForDelivery.NativeMethodInfoPtr_End_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_WaitForDelivery>.NativeClassPtr, 100669836);
			NPCSignal_WaitForDelivery.NativeMethodInfoPtr_Skipped_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_WaitForDelivery>.NativeClassPtr, 100669837);
			NPCSignal_WaitForDelivery.NativeMethodInfoPtr_IsAtDestination_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_WaitForDelivery>.NativeClassPtr, 100669838);
			NPCSignal_WaitForDelivery.NativeMethodInfoPtr_WalkCallback_Protected_Virtual_Void_WalkResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_WaitForDelivery>.NativeClassPtr, 100669839);
			NPCSignal_WaitForDelivery.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_WaitForDelivery>.NativeClassPtr, 100669840);
			NPCSignal_WaitForDelivery.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_WaitForDelivery>.NativeClassPtr, 100669841);
			NPCSignal_WaitForDelivery.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_WaitForDelivery>.NativeClassPtr, 100669842);
			NPCSignal_WaitForDelivery.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_WaitForDelivery>.NativeClassPtr, 100669843);
			NPCSignal_WaitForDelivery.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCSignal_WaitForDelivery>.NativeClassPtr, 100669844);
		}

		// Token: 0x170011F5 RID: 4597
		// (get) Token: 0x06003851 RID: 14417 RVA: 0x001273A8 File Offset: 0x001255A8
		public new unsafe string ActionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141270, XrefRangeEnd = 141272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSignal_WaitForDelivery.NativeMethodInfoPtr_get_ActionName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003852 RID: 14418 RVA: 0x001273E0 File Offset: 0x001255E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141272, XrefRangeEnd = 141273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal_WaitForDelivery.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003853 RID: 14419 RVA: 0x0012741C File Offset: 0x0012561C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141273, XrefRangeEnd = 141275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal_WaitForDelivery.NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003854 RID: 14420 RVA: 0x00127458 File Offset: 0x00125658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal_WaitForDelivery.NativeMethodInfoPtr_GetName_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003855 RID: 14421 RVA: 0x0012749C File Offset: 0x0012569C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141275, XrefRangeEnd = 141278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Started()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal_WaitForDelivery.NativeMethodInfoPtr_Started_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003856 RID: 14422 RVA: 0x001274D8 File Offset: 0x001256D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141278, XrefRangeEnd = 141288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ActiveMinPassed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal_WaitForDelivery.NativeMethodInfoPtr_ActiveMinPassed_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003857 RID: 14423 RVA: 0x00127514 File Offset: 0x00125714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141288, XrefRangeEnd = 141295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void LateStarted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal_WaitForDelivery.NativeMethodInfoPtr_LateStarted_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003858 RID: 14424 RVA: 0x00127550 File Offset: 0x00125750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141295, XrefRangeEnd = 141302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void JumpTo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal_WaitForDelivery.NativeMethodInfoPtr_JumpTo_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003859 RID: 14425 RVA: 0x0012758C File Offset: 0x0012578C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141302, XrefRangeEnd = 141308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Interrupt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal_WaitForDelivery.NativeMethodInfoPtr_Interrupt_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600385A RID: 14426 RVA: 0x001275C8 File Offset: 0x001257C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141308, XrefRangeEnd = 141313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal_WaitForDelivery.NativeMethodInfoPtr_Resume_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600385B RID: 14427 RVA: 0x00127604 File Offset: 0x00125804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141313, XrefRangeEnd = 141318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal_WaitForDelivery.NativeMethodInfoPtr_End_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600385C RID: 14428 RVA: 0x00127640 File Offset: 0x00125840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141318, XrefRangeEnd = 141322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Skipped()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal_WaitForDelivery.NativeMethodInfoPtr_Skipped_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600385D RID: 14429 RVA: 0x0012767C File Offset: 0x0012587C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141322, XrefRangeEnd = 141329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAtDestination()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSignal_WaitForDelivery.NativeMethodInfoPtr_IsAtDestination_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600385E RID: 14430 RVA: 0x001276B8 File Offset: 0x001258B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141329, XrefRangeEnd = 141335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WalkCallback(NPCMovement.WalkResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal_WaitForDelivery.NativeMethodInfoPtr_WalkCallback_Protected_Virtual_Void_WalkResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600385F RID: 14431 RVA: 0x00127704 File Offset: 0x00125904
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 140574, RefRangeEnd = 140579, XrefRangeStart = 140574, XrefRangeEnd = 140579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCSignal_WaitForDelivery() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCSignal_WaitForDelivery>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCSignal_WaitForDelivery.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003860 RID: 14432 RVA: 0x00127740 File Offset: 0x00125940
		[CallerCount(0)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal_WaitForDelivery.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003861 RID: 14433 RVA: 0x0012777C File Offset: 0x0012597C
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal_WaitForDelivery.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003862 RID: 14434 RVA: 0x001277B8 File Offset: 0x001259B8
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal_WaitForDelivery.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003863 RID: 14435 RVA: 0x001277F4 File Offset: 0x001259F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 141335, XrefRangeEnd = 141336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCSignal_WaitForDelivery.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003864 RID: 14436 RVA: 0x0001D1BB File Offset: 0x0001B3BB
		public NPCSignal_WaitForDelivery(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170011F1 RID: 4593
		// (get) Token: 0x06003865 RID: 14437 RVA: 0x00127830 File Offset: 0x00125A30
		// (set) Token: 0x06003866 RID: 14438 RVA: 0x0001D1C4 File Offset: 0x0001B3C4
		public unsafe static float DESTINATION_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCSignal_WaitForDelivery.NativeFieldInfoPtr_DESTINATION_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCSignal_WaitForDelivery.NativeFieldInfoPtr_DESTINATION_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x170011F2 RID: 4594
		// (get) Token: 0x06003867 RID: 14439 RVA: 0x0012784C File Offset: 0x00125A4C
		// (set) Token: 0x06003868 RID: 14440 RVA: 0x0001D1D2 File Offset: 0x0001B3D2
		public unsafe DeliveryLocation Location
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSignal_WaitForDelivery.NativeFieldInfoPtr_Location);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeliveryLocation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSignal_WaitForDelivery.NativeFieldInfoPtr_Location), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011F3 RID: 4595
		// (get) Token: 0x06003869 RID: 14441 RVA: 0x0012787C File Offset: 0x00125A7C
		// (set) Token: 0x0600386A RID: 14442 RVA: 0x0001D1F1 File Offset: 0x0001B3F1
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSignal_WaitForDelivery.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSignal_WaitForDelivery.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170011F4 RID: 4596
		// (get) Token: 0x0600386B RID: 14443 RVA: 0x001278A4 File Offset: 0x00125AA4
		// (set) Token: 0x0600386C RID: 14444 RVA: 0x0001D20C File Offset: 0x0001B40C
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSignal_WaitForDelivery.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCSignal_WaitForDelivery.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002518 RID: 9496
		private static readonly IntPtr NativeFieldInfoPtr_DESTINATION_THRESHOLD;

		// Token: 0x04002519 RID: 9497
		private static readonly IntPtr NativeFieldInfoPtr_Location;

		// Token: 0x0400251A RID: 9498
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400251B RID: 9499
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400251C RID: 9500
		private static readonly IntPtr NativeMethodInfoPtr_get_ActionName_Public_get_String_0;

		// Token: 0x0400251D RID: 9501
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x0400251E RID: 9502
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Protected_Virtual_Void_1;

		// Token: 0x0400251F RID: 9503
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_Virtual_String_0;

		// Token: 0x04002520 RID: 9504
		private static readonly IntPtr NativeMethodInfoPtr_Started_Public_Virtual_Void_0;

		// Token: 0x04002521 RID: 9505
		private static readonly IntPtr NativeMethodInfoPtr_ActiveMinPassed_Public_Virtual_Void_0;

		// Token: 0x04002522 RID: 9506
		private static readonly IntPtr NativeMethodInfoPtr_LateStarted_Public_Virtual_Void_0;

		// Token: 0x04002523 RID: 9507
		private static readonly IntPtr NativeMethodInfoPtr_JumpTo_Public_Virtual_Void_0;

		// Token: 0x04002524 RID: 9508
		private static readonly IntPtr NativeMethodInfoPtr_Interrupt_Public_Virtual_Void_0;

		// Token: 0x04002525 RID: 9509
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Public_Virtual_Void_0;

		// Token: 0x04002526 RID: 9510
		private static readonly IntPtr NativeMethodInfoPtr_End_Public_Virtual_Void_0;

		// Token: 0x04002527 RID: 9511
		private static readonly IntPtr NativeMethodInfoPtr_Skipped_Public_Virtual_Void_0;

		// Token: 0x04002528 RID: 9512
		private static readonly IntPtr NativeMethodInfoPtr_IsAtDestination_Private_Boolean_0;

		// Token: 0x04002529 RID: 9513
		private static readonly IntPtr NativeMethodInfoPtr_WalkCallback_Protected_Virtual_Void_WalkResult_0;

		// Token: 0x0400252A RID: 9514
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400252B RID: 9515
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400252C RID: 9516
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400252D RID: 9517
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400252E RID: 9518
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;
	}
}
