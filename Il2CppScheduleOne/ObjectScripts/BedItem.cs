using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Storage;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000730 RID: 1840
	public class BedItem : PlaceableStorageEntity
	{
		// Token: 0x0600A743 RID: 42819 RVA: 0x0029CC00 File Offset: 0x0029AE00
		// Note: this type is marked as 'beforefieldinit'.
		static BedItem()
		{
			Il2CppClassPointerStore<BedItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "BedItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BedItem>.NativeClassPtr);
			BedItem.NativeFieldInfoPtr_Bed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BedItem>.NativeClassPtr, "Bed");
			BedItem.NativeFieldInfoPtr_Storage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BedItem>.NativeClassPtr, "Storage");
			BedItem.NativeFieldInfoPtr_Briefcase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BedItem>.NativeClassPtr, "Briefcase");
			BedItem.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BedItem>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.ObjectScripts.BedItemAssembly-CSharp.dll_Excuted");
			BedItem.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BedItem>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.ObjectScripts.BedItemAssembly-CSharp.dll_Excuted");
			BedItem.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BedItem>.NativeClassPtr, 100683758);
			BedItem.NativeMethodInfoPtr_IsBedValid_Public_Static_Boolean_BuildableItem_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BedItem>.NativeClassPtr, 100683759);
			BedItem.NativeMethodInfoPtr_UpdateBriefcase_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BedItem>.NativeClassPtr, 100683760);
			BedItem.NativeMethodInfoPtr_GetCashSum_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BedItem>.NativeClassPtr, 100683761);
			BedItem.NativeMethodInfoPtr_RemoveCash_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BedItem>.NativeClassPtr, 100683762);
			BedItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BedItem>.NativeClassPtr, 100683763);
			BedItem.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BedItem>.NativeClassPtr, 100683764);
			BedItem.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BedItem>.NativeClassPtr, 100683765);
			BedItem.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BedItem>.NativeClassPtr, 100683766);
			BedItem.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BedItem>.NativeClassPtr, 100683767);
		}

		// Token: 0x0600A744 RID: 42820 RVA: 0x0029CD5C File Offset: 0x0029AF5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291146, XrefRangeEnd = 291156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BedItem.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A745 RID: 42821 RVA: 0x0029CD98 File Offset: 0x0029AF98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291156, XrefRangeEnd = 291166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsBedValid(BuildableItem obj, out string reason)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BedItem.NativeMethodInfoPtr_IsBedValid_Public_Static_Boolean_BuildableItem_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600A746 RID: 42822 RVA: 0x0029CDF4 File Offset: 0x0029AFF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 291218, RefRangeEnd = 291219, XrefRangeStart = 291166, XrefRangeEnd = 291218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateBriefcase()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BedItem.NativeMethodInfoPtr_UpdateBriefcase_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A747 RID: 42823 RVA: 0x0029CE28 File Offset: 0x0029B028
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 291236, RefRangeEnd = 291239, XrefRangeStart = 291219, XrefRangeEnd = 291236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetCashSum()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BedItem.NativeMethodInfoPtr_GetCashSum_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A748 RID: 42824 RVA: 0x0029CE64 File Offset: 0x0029B064
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 291261, RefRangeEnd = 291263, XrefRangeStart = 291239, XrefRangeEnd = 291261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveCash(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BedItem.NativeMethodInfoPtr_RemoveCash_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A749 RID: 42825 RVA: 0x0029CEA4 File Offset: 0x0029B0A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291263, XrefRangeEnd = 291264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BedItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BedItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BedItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A74A RID: 42826 RVA: 0x0029CEE0 File Offset: 0x0029B0E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291264, XrefRangeEnd = 291265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BedItem.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A74B RID: 42827 RVA: 0x0029CF1C File Offset: 0x0029B11C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291265, XrefRangeEnd = 291266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BedItem.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A74C RID: 42828 RVA: 0x0029CF58 File Offset: 0x0029B158
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BedItem.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A74D RID: 42829 RVA: 0x0029CF94 File Offset: 0x0029B194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291266, XrefRangeEnd = 291267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BedItem.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A74E RID: 42830 RVA: 0x000526C6 File Offset: 0x000508C6
		public BedItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170033A0 RID: 13216
		// (get) Token: 0x0600A74F RID: 42831 RVA: 0x0029CFD0 File Offset: 0x0029B1D0
		// (set) Token: 0x0600A750 RID: 42832 RVA: 0x000526CF File Offset: 0x000508CF
		public unsafe Bed Bed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BedItem.NativeFieldInfoPtr_Bed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Bed>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BedItem.NativeFieldInfoPtr_Bed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033A1 RID: 13217
		// (get) Token: 0x0600A751 RID: 42833 RVA: 0x0029D000 File Offset: 0x0029B200
		// (set) Token: 0x0600A752 RID: 42834 RVA: 0x000526EE File Offset: 0x000508EE
		public unsafe StorageEntity Storage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BedItem.NativeFieldInfoPtr_Storage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageEntity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BedItem.NativeFieldInfoPtr_Storage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033A2 RID: 13218
		// (get) Token: 0x0600A753 RID: 42835 RVA: 0x0029D030 File Offset: 0x0029B230
		// (set) Token: 0x0600A754 RID: 42836 RVA: 0x0005270D File Offset: 0x0005090D
		public unsafe GameObject Briefcase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BedItem.NativeFieldInfoPtr_Briefcase);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BedItem.NativeFieldInfoPtr_Briefcase), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033A3 RID: 13219
		// (get) Token: 0x0600A755 RID: 42837 RVA: 0x0029D060 File Offset: 0x0029B260
		// (set) Token: 0x0600A756 RID: 42838 RVA: 0x0005272C File Offset: 0x0005092C
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BedItem.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BedItem.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170033A4 RID: 13220
		// (get) Token: 0x0600A757 RID: 42839 RVA: 0x0029D088 File Offset: 0x0029B288
		// (set) Token: 0x0600A758 RID: 42840 RVA: 0x00052747 File Offset: 0x00050947
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BedItem.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BedItem.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04007030 RID: 28720
		private static readonly IntPtr NativeFieldInfoPtr_Bed;

		// Token: 0x04007031 RID: 28721
		private static readonly IntPtr NativeFieldInfoPtr_Storage;

		// Token: 0x04007032 RID: 28722
		private static readonly IntPtr NativeFieldInfoPtr_Briefcase;

		// Token: 0x04007033 RID: 28723
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04007034 RID: 28724
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04007035 RID: 28725
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04007036 RID: 28726
		private static readonly IntPtr NativeMethodInfoPtr_IsBedValid_Public_Static_Boolean_BuildableItem_byref_String_0;

		// Token: 0x04007037 RID: 28727
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBriefcase_Private_Void_0;

		// Token: 0x04007038 RID: 28728
		private static readonly IntPtr NativeMethodInfoPtr_GetCashSum_Public_Single_0;

		// Token: 0x04007039 RID: 28729
		private static readonly IntPtr NativeMethodInfoPtr_RemoveCash_Public_Void_Single_0;

		// Token: 0x0400703A RID: 28730
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400703B RID: 28731
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400703C RID: 28732
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400703D RID: 28733
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400703E RID: 28734
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
