using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Economy;
using UnityEngine.Events;

namespace Il2CppScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x0200033B RID: 827
	public class Benji : Dealer
	{
		// Token: 0x06003CE9 RID: 15593 RVA: 0x001367C8 File Offset: 0x001349C8
		// Note: this type is marked as 'beforefieldinit'.
		static Benji()
		{
			Il2CppClassPointerStore<Benji>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.CharacterClasses", "Benji");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Benji>.NativeClassPtr);
			Benji.NativeFieldInfoPtr_onRecruitmentRequested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Benji>.NativeClassPtr, "onRecruitmentRequested");
			Benji.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Benji>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.BenjiAssembly-CSharp.dll_Excuted");
			Benji.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Benji>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.BenjiAssembly-CSharp.dll_Excuted");
			Benji.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Benji>.NativeClassPtr, 100670399);
			Benji.NativeMethodInfoPtr_AddCustomer_Protected_Virtual_Void_Customer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Benji>.NativeClassPtr, 100670400);
			Benji.NativeMethodInfoPtr_RemoveCustomer_Public_Virtual_Void_Customer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Benji>.NativeClassPtr, 100670401);
			Benji.NativeMethodInfoPtr_RecruitmentRequested_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Benji>.NativeClassPtr, 100670402);
			Benji.NativeMethodInfoPtr_UpdatePotentialDealerPoI_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Benji>.NativeClassPtr, 100670403);
			Benji.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Benji>.NativeClassPtr, 100670404);
			Benji.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Benji>.NativeClassPtr, 100670405);
			Benji.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Benji>.NativeClassPtr, 100670406);
			Benji.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Benji>.NativeClassPtr, 100670407);
			Benji.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Benji>.NativeClassPtr, 100670408);
		}

		// Token: 0x06003CEA RID: 15594 RVA: 0x001368FC File Offset: 0x00134AFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143102, XrefRangeEnd = 143147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Benji.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CEB RID: 15595 RVA: 0x00136938 File Offset: 0x00134B38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143147, XrefRangeEnd = 143157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AddCustomer(Customer customer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(customer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Benji.NativeMethodInfoPtr_AddCustomer_Protected_Virtual_Void_Customer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CEC RID: 15596 RVA: 0x00136988 File Offset: 0x00134B88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143157, XrefRangeEnd = 143167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RemoveCustomer(Customer customer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(customer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Benji.NativeMethodInfoPtr_RemoveCustomer_Public_Virtual_Void_Customer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CED RID: 15597 RVA: 0x001369D8 File Offset: 0x00134BD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143167, XrefRangeEnd = 143169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RecruitmentRequested()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Benji.NativeMethodInfoPtr_RecruitmentRequested_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CEE RID: 15598 RVA: 0x00136A14 File Offset: 0x00134C14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143169, XrefRangeEnd = 143172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdatePotentialDealerPoI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Benji.NativeMethodInfoPtr_UpdatePotentialDealerPoI_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CEF RID: 15599 RVA: 0x00136A50 File Offset: 0x00134C50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143172, XrefRangeEnd = 143176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Benji() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Benji>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Benji.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CF0 RID: 15600 RVA: 0x00136A8C File Offset: 0x00134C8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143176, XrefRangeEnd = 143177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Benji.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CF1 RID: 15601 RVA: 0x00136AC8 File Offset: 0x00134CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143177, XrefRangeEnd = 143178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Benji.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CF2 RID: 15602 RVA: 0x00136B04 File Offset: 0x00134D04
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Benji.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CF3 RID: 15603 RVA: 0x00136B40 File Offset: 0x00134D40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Benji.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003CF4 RID: 15604 RVA: 0x0001ED53 File Offset: 0x0001CF53
		public Benji(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170012EC RID: 4844
		// (get) Token: 0x06003CF5 RID: 15605 RVA: 0x00136B7C File Offset: 0x00134D7C
		// (set) Token: 0x06003CF6 RID: 15606 RVA: 0x0001ED5C File Offset: 0x0001CF5C
		public unsafe UnityEvent onRecruitmentRequested
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benji.NativeFieldInfoPtr_onRecruitmentRequested);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benji.NativeFieldInfoPtr_onRecruitmentRequested), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012ED RID: 4845
		// (get) Token: 0x06003CF7 RID: 15607 RVA: 0x00136BAC File Offset: 0x00134DAC
		// (set) Token: 0x06003CF8 RID: 15608 RVA: 0x0001ED7B File Offset: 0x0001CF7B
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benji.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benji.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170012EE RID: 4846
		// (get) Token: 0x06003CF9 RID: 15609 RVA: 0x00136BD4 File Offset: 0x00134DD4
		// (set) Token: 0x06003CFA RID: 15610 RVA: 0x0001ED96 File Offset: 0x0001CF96
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benji.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Benji.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x0400282D RID: 10285
		private static readonly IntPtr NativeFieldInfoPtr_onRecruitmentRequested;

		// Token: 0x0400282E RID: 10286
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400282F RID: 10287
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002830 RID: 10288
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0;

		// Token: 0x04002831 RID: 10289
		private static readonly IntPtr NativeMethodInfoPtr_AddCustomer_Protected_Virtual_Void_Customer_0;

		// Token: 0x04002832 RID: 10290
		private static readonly IntPtr NativeMethodInfoPtr_RemoveCustomer_Public_Virtual_Void_Customer_0;

		// Token: 0x04002833 RID: 10291
		private static readonly IntPtr NativeMethodInfoPtr_RecruitmentRequested_Protected_Virtual_Void_0;

		// Token: 0x04002834 RID: 10292
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePotentialDealerPoI_Protected_Virtual_Void_0;

		// Token: 0x04002835 RID: 10293
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002836 RID: 10294
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002837 RID: 10295
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002838 RID: 10296
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002839 RID: 10297
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
