using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Management.Presets.Options
{
	// Token: 0x020003AE RID: 942
	public class ItemList : Option
	{
		// Token: 0x06004998 RID: 18840 RVA: 0x001666DC File Offset: 0x001648DC
		// Note: this type is marked as 'beforefieldinit'.
		static ItemList()
		{
			Il2CppClassPointerStore<ItemList>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management.Presets.Options", "ItemList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemList>.NativeClassPtr);
			ItemList.NativeFieldInfoPtr_All = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemList>.NativeClassPtr, "All");
			ItemList.NativeFieldInfoPtr_None = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemList>.NativeClassPtr, "None");
			ItemList.NativeFieldInfoPtr_Selection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemList>.NativeClassPtr, "Selection");
			ItemList.NativeFieldInfoPtr__CanBeAll_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemList>.NativeClassPtr, "<CanBeAll>k__BackingField");
			ItemList.NativeFieldInfoPtr__CanBeNone_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemList>.NativeClassPtr, "<CanBeNone>k__BackingField");
			ItemList.NativeFieldInfoPtr__OptionList_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemList>.NativeClassPtr, "<OptionList>k__BackingField");
			ItemList.NativeMethodInfoPtr_get_CanBeAll_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemList>.NativeClassPtr, 100672432);
			ItemList.NativeMethodInfoPtr_set_CanBeAll_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemList>.NativeClassPtr, 100672433);
			ItemList.NativeMethodInfoPtr_get_CanBeNone_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemList>.NativeClassPtr, 100672434);
			ItemList.NativeMethodInfoPtr_set_CanBeNone_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemList>.NativeClassPtr, 100672435);
			ItemList.NativeMethodInfoPtr_get_OptionList_Public_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemList>.NativeClassPtr, 100672436);
			ItemList.NativeMethodInfoPtr_set_OptionList_Protected_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemList>.NativeClassPtr, 100672437);
			ItemList.NativeMethodInfoPtr__ctor_Public_Void_String_List_1_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemList>.NativeClassPtr, 100672438);
			ItemList.NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Option_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemList>.NativeClassPtr, 100672439);
			ItemList.NativeMethodInfoPtr_GetDisplayString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemList>.NativeClassPtr, 100672440);
		}

		// Token: 0x17001616 RID: 5654
		// (get) Token: 0x06004999 RID: 18841 RVA: 0x00166838 File Offset: 0x00164A38
		// (set) Token: 0x0600499A RID: 18842 RVA: 0x00166874 File Offset: 0x00164A74
		public unsafe bool CanBeAll
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemList.NativeMethodInfoPtr_get_CanBeAll_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 37988, RefRangeEnd = 38011, XrefRangeStart = 37988, XrefRangeEnd = 38011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemList.NativeMethodInfoPtr_set_CanBeAll_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001617 RID: 5655
		// (get) Token: 0x0600499B RID: 18843 RVA: 0x001668B4 File Offset: 0x00164AB4
		// (set) Token: 0x0600499C RID: 18844 RVA: 0x001668F0 File Offset: 0x00164AF0
		public unsafe bool CanBeNone
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemList.NativeMethodInfoPtr_get_CanBeNone_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemList.NativeMethodInfoPtr_set_CanBeNone_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001618 RID: 5656
		// (get) Token: 0x0600499D RID: 18845 RVA: 0x00166930 File Offset: 0x00164B30
		// (set) Token: 0x0600499E RID: 18846 RVA: 0x00166970 File Offset: 0x00164B70
		public unsafe List<string> OptionList
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 19646, RefRangeEnd = 19660, XrefRangeStart = 19646, XrefRangeEnd = 19660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemList.NativeMethodInfoPtr_get_OptionList_Public_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 19661, RefRangeEnd = 19662, XrefRangeStart = 19661, XrefRangeEnd = 19662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemList.NativeMethodInfoPtr_set_OptionList_Protected_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600499F RID: 18847 RVA: 0x001669B4 File Offset: 0x00164BB4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 163460, RefRangeEnd = 163462, XrefRangeStart = 163439, XrefRangeEnd = 163460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemList(string name, List<string> optionList, bool canBeAll, bool canBeNone) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemList>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(optionList);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canBeAll;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canBeNone;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemList.NativeMethodInfoPtr__ctor_Public_Void_String_List_1_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049A0 RID: 18848 RVA: 0x00166A30 File Offset: 0x00164C30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163462, XrefRangeEnd = 163478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CopyTo(Option other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemList.NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Option_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049A1 RID: 18849 RVA: 0x00166A80 File Offset: 0x00164C80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163478, XrefRangeEnd = 163501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetDisplayString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemList.NativeMethodInfoPtr_GetDisplayString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060049A2 RID: 18850 RVA: 0x00023738 File Offset: 0x00021938
		public ItemList(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001610 RID: 5648
		// (get) Token: 0x060049A3 RID: 18851 RVA: 0x00166AC4 File Offset: 0x00164CC4
		// (set) Token: 0x060049A4 RID: 18852 RVA: 0x00023741 File Offset: 0x00021941
		public unsafe bool All
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemList.NativeFieldInfoPtr_All);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemList.NativeFieldInfoPtr_All)) = value;
			}
		}

		// Token: 0x17001611 RID: 5649
		// (get) Token: 0x060049A5 RID: 18853 RVA: 0x00166AEC File Offset: 0x00164CEC
		// (set) Token: 0x060049A6 RID: 18854 RVA: 0x0002375C File Offset: 0x0002195C
		public unsafe bool None
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemList.NativeFieldInfoPtr_None);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemList.NativeFieldInfoPtr_None)) = value;
			}
		}

		// Token: 0x17001612 RID: 5650
		// (get) Token: 0x060049A7 RID: 18855 RVA: 0x00166B14 File Offset: 0x00164D14
		// (set) Token: 0x060049A8 RID: 18856 RVA: 0x00023777 File Offset: 0x00021977
		public unsafe List<string> Selection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemList.NativeFieldInfoPtr_Selection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemList.NativeFieldInfoPtr_Selection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001613 RID: 5651
		// (get) Token: 0x060049A9 RID: 18857 RVA: 0x00166B44 File Offset: 0x00164D44
		// (set) Token: 0x060049AA RID: 18858 RVA: 0x00023796 File Offset: 0x00021996
		public unsafe bool _CanBeAll_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemList.NativeFieldInfoPtr__CanBeAll_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemList.NativeFieldInfoPtr__CanBeAll_k__BackingField)) = value;
			}
		}

		// Token: 0x17001614 RID: 5652
		// (get) Token: 0x060049AB RID: 18859 RVA: 0x00166B6C File Offset: 0x00164D6C
		// (set) Token: 0x060049AC RID: 18860 RVA: 0x000237B1 File Offset: 0x000219B1
		public unsafe bool _CanBeNone_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemList.NativeFieldInfoPtr__CanBeNone_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemList.NativeFieldInfoPtr__CanBeNone_k__BackingField)) = value;
			}
		}

		// Token: 0x17001615 RID: 5653
		// (get) Token: 0x060049AD RID: 18861 RVA: 0x00166B94 File Offset: 0x00164D94
		// (set) Token: 0x060049AE RID: 18862 RVA: 0x000237CC File Offset: 0x000219CC
		public unsafe List<string> _OptionList_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemList.NativeFieldInfoPtr__OptionList_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemList.NativeFieldInfoPtr__OptionList_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040031A3 RID: 12707
		private static readonly IntPtr NativeFieldInfoPtr_All;

		// Token: 0x040031A4 RID: 12708
		private static readonly IntPtr NativeFieldInfoPtr_None;

		// Token: 0x040031A5 RID: 12709
		private static readonly IntPtr NativeFieldInfoPtr_Selection;

		// Token: 0x040031A6 RID: 12710
		private static readonly IntPtr NativeFieldInfoPtr__CanBeAll_k__BackingField;

		// Token: 0x040031A7 RID: 12711
		private static readonly IntPtr NativeFieldInfoPtr__CanBeNone_k__BackingField;

		// Token: 0x040031A8 RID: 12712
		private static readonly IntPtr NativeFieldInfoPtr__OptionList_k__BackingField;

		// Token: 0x040031A9 RID: 12713
		private static readonly IntPtr NativeMethodInfoPtr_get_CanBeAll_Public_get_Boolean_0;

		// Token: 0x040031AA RID: 12714
		private static readonly IntPtr NativeMethodInfoPtr_set_CanBeAll_Protected_set_Void_Boolean_0;

		// Token: 0x040031AB RID: 12715
		private static readonly IntPtr NativeMethodInfoPtr_get_CanBeNone_Public_get_Boolean_0;

		// Token: 0x040031AC RID: 12716
		private static readonly IntPtr NativeMethodInfoPtr_set_CanBeNone_Protected_set_Void_Boolean_0;

		// Token: 0x040031AD RID: 12717
		private static readonly IntPtr NativeMethodInfoPtr_get_OptionList_Public_get_List_1_String_0;

		// Token: 0x040031AE RID: 12718
		private static readonly IntPtr NativeMethodInfoPtr_set_OptionList_Protected_set_Void_List_1_String_0;

		// Token: 0x040031AF RID: 12719
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_List_1_String_Boolean_Boolean_0;

		// Token: 0x040031B0 RID: 12720
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Option_0;

		// Token: 0x040031B1 RID: 12721
		private static readonly IntPtr NativeMethodInfoPtr_GetDisplayString_Public_Virtual_String_0;
	}
}
