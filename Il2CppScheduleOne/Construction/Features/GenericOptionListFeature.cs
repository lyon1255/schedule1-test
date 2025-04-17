using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.UI.Construction.Features;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Construction.Features
{
	// Token: 0x02000484 RID: 1156
	public class GenericOptionListFeature : OptionListFeature
	{
		// Token: 0x0600644C RID: 25676 RVA: 0x001C5DD0 File Offset: 0x001C3FD0
		// Note: this type is marked as 'beforefieldinit'.
		static GenericOptionListFeature()
		{
			Il2CppClassPointerStore<GenericOptionListFeature>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Construction.Features", "GenericOptionListFeature");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericOptionListFeature>.NativeClassPtr);
			GenericOptionListFeature.NativeFieldInfoPtr_options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericOptionListFeature>.NativeClassPtr, "options");
			GenericOptionListFeature.NativeFieldInfoPtr_visibleOption = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericOptionListFeature>.NativeClassPtr, "visibleOption");
			GenericOptionListFeature.NativeFieldInfoPtr_installedOption = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericOptionListFeature>.NativeClassPtr, "installedOption");
			GenericOptionListFeature.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericOptionListFeature>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Construction.Features.GenericOptionListFeatureAssembly-CSharp.dll_Excuted");
			GenericOptionListFeature.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericOptionListFeature>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Construction.Features.GenericOptionListFeatureAssembly-CSharp.dll_Excuted");
			GenericOptionListFeature.NativeMethodInfoPtr_Default_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericOptionListFeature>.NativeClassPtr, 100676005);
			GenericOptionListFeature.NativeMethodInfoPtr_GetOptions_Protected_Virtual_List_1_Option_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericOptionListFeature>.NativeClassPtr, 100676006);
			GenericOptionListFeature.NativeMethodInfoPtr_SelectOption_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericOptionListFeature>.NativeClassPtr, 100676007);
			GenericOptionListFeature.NativeMethodInfoPtr_PurchaseOption_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericOptionListFeature>.NativeClassPtr, 100676008);
			GenericOptionListFeature.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericOptionListFeature>.NativeClassPtr, 100676009);
			GenericOptionListFeature.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericOptionListFeature>.NativeClassPtr, 100676010);
			GenericOptionListFeature.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericOptionListFeature>.NativeClassPtr, 100676011);
			GenericOptionListFeature.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericOptionListFeature>.NativeClassPtr, 100676012);
			GenericOptionListFeature.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericOptionListFeature>.NativeClassPtr, 100676013);
		}

		// Token: 0x0600644D RID: 25677 RVA: 0x001C5F18 File Offset: 0x001C4118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204062, XrefRangeEnd = 204068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Default()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericOptionListFeature.NativeMethodInfoPtr_Default_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600644E RID: 25678 RVA: 0x001C5F54 File Offset: 0x001C4154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204068, XrefRangeEnd = 204097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override List<FI_OptionList.Option> GetOptions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericOptionListFeature.NativeMethodInfoPtr_GetOptions_Protected_Virtual_List_1_Option_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<FI_OptionList.Option>>(intPtr3) : null;
		}

		// Token: 0x0600644F RID: 25679 RVA: 0x001C5FA0 File Offset: 0x001C41A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204097, XrefRangeEnd = 204111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SelectOption(int optionIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref optionIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericOptionListFeature.NativeMethodInfoPtr_SelectOption_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006450 RID: 25680 RVA: 0x001C5FEC File Offset: 0x001C41EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204111, XrefRangeEnd = 204125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PurchaseOption(int optionIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref optionIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericOptionListFeature.NativeMethodInfoPtr_PurchaseOption_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006451 RID: 25681 RVA: 0x001C6038 File Offset: 0x001C4238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204125, XrefRangeEnd = 204137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GenericOptionListFeature() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericOptionListFeature>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericOptionListFeature.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006452 RID: 25682 RVA: 0x001C6074 File Offset: 0x001C4274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204137, XrefRangeEnd = 204138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericOptionListFeature.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006453 RID: 25683 RVA: 0x001C60B0 File Offset: 0x001C42B0
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericOptionListFeature.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006454 RID: 25684 RVA: 0x001C60EC File Offset: 0x001C42EC
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericOptionListFeature.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006455 RID: 25685 RVA: 0x001C6128 File Offset: 0x001C4328
		[CallerCount(0)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericOptionListFeature.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006456 RID: 25686 RVA: 0x0002F720 File Offset: 0x0002D920
		public GenericOptionListFeature(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E3E RID: 7742
		// (get) Token: 0x06006457 RID: 25687 RVA: 0x001C6164 File Offset: 0x001C4364
		// (set) Token: 0x06006458 RID: 25688 RVA: 0x0002F729 File Offset: 0x0002D929
		public unsafe List<GenericOption> options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOptionListFeature.NativeFieldInfoPtr_options);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GenericOption>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOptionListFeature.NativeFieldInfoPtr_options), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E3F RID: 7743
		// (get) Token: 0x06006459 RID: 25689 RVA: 0x001C6194 File Offset: 0x001C4394
		// (set) Token: 0x0600645A RID: 25690 RVA: 0x0002F748 File Offset: 0x0002D948
		public unsafe GenericOption visibleOption
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOptionListFeature.NativeFieldInfoPtr_visibleOption);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GenericOption>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOptionListFeature.NativeFieldInfoPtr_visibleOption), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E40 RID: 7744
		// (get) Token: 0x0600645B RID: 25691 RVA: 0x001C61C4 File Offset: 0x001C43C4
		// (set) Token: 0x0600645C RID: 25692 RVA: 0x0002F767 File Offset: 0x0002D967
		public unsafe GenericOption installedOption
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOptionListFeature.NativeFieldInfoPtr_installedOption);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GenericOption>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOptionListFeature.NativeFieldInfoPtr_installedOption), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E41 RID: 7745
		// (get) Token: 0x0600645D RID: 25693 RVA: 0x001C61F4 File Offset: 0x001C43F4
		// (set) Token: 0x0600645E RID: 25694 RVA: 0x0002F786 File Offset: 0x0002D986
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOptionListFeature.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOptionListFeature.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001E42 RID: 7746
		// (get) Token: 0x0600645F RID: 25695 RVA: 0x001C621C File Offset: 0x001C441C
		// (set) Token: 0x06006460 RID: 25696 RVA: 0x0002F7A1 File Offset: 0x0002D9A1
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOptionListFeature.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOptionListFeature.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04004470 RID: 17520
		private static readonly IntPtr NativeFieldInfoPtr_options;

		// Token: 0x04004471 RID: 17521
		private static readonly IntPtr NativeFieldInfoPtr_visibleOption;

		// Token: 0x04004472 RID: 17522
		private static readonly IntPtr NativeFieldInfoPtr_installedOption;

		// Token: 0x04004473 RID: 17523
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04004474 RID: 17524
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04004475 RID: 17525
		private static readonly IntPtr NativeMethodInfoPtr_Default_Public_Virtual_Void_0;

		// Token: 0x04004476 RID: 17526
		private static readonly IntPtr NativeMethodInfoPtr_GetOptions_Protected_Virtual_List_1_Option_0;

		// Token: 0x04004477 RID: 17527
		private static readonly IntPtr NativeMethodInfoPtr_SelectOption_Public_Virtual_Void_Int32_0;

		// Token: 0x04004478 RID: 17528
		private static readonly IntPtr NativeMethodInfoPtr_PurchaseOption_Public_Virtual_Void_Int32_0;

		// Token: 0x04004479 RID: 17529
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400447A RID: 17530
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400447B RID: 17531
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400447C RID: 17532
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400447D RID: 17533
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
