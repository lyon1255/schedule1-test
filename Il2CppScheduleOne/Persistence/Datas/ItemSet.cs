using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000258 RID: 600
	[Serializable]
	public class ItemSet : Object
	{
		// Token: 0x06002EA3 RID: 11939 RVA: 0x00105528 File Offset: 0x00103728
		// Note: this type is marked as 'beforefieldinit'.
		static ItemSet()
		{
			Il2CppClassPointerStore<ItemSet>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "ItemSet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemSet>.NativeClassPtr);
			ItemSet.NativeFieldInfoPtr_Items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemSet>.NativeClassPtr, "Items");
			ItemSet.NativeMethodInfoPtr__ctor_Public_Void_List_1_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSet>.NativeClassPtr, 100668718);
			ItemSet.NativeMethodInfoPtr_GetJSON_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSet>.NativeClassPtr, 100668719);
			ItemSet.NativeMethodInfoPtr__ctor_Public_Void_List_1_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSet>.NativeClassPtr, 100668720);
			ItemSet.NativeMethodInfoPtr__ctor_Public_Void_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSet>.NativeClassPtr, 100668721);
			ItemSet.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSet>.NativeClassPtr, 100668722);
			ItemSet.NativeMethodInfoPtr_Deserialize_Public_Static_Il2CppReferenceArray_1_ItemInstance_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemSet>.NativeClassPtr, 100668723);
		}

		// Token: 0x06002EA4 RID: 11940 RVA: 0x001055E4 File Offset: 0x001037E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130286, XrefRangeEnd = 130297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemSet(List<ItemData> items) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemSet>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSet.NativeMethodInfoPtr__ctor_Public_Void_List_1_ItemData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EA5 RID: 11941 RVA: 0x00105630 File Offset: 0x00103830
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 130298, RefRangeEnd = 130302, XrefRangeStart = 130297, XrefRangeEnd = 130298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetJSON()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSet.NativeMethodInfoPtr_GetJSON_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002EA6 RID: 11942 RVA: 0x00105668 File Offset: 0x00103868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130302, XrefRangeEnd = 130313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemSet(List<ItemInstance> items) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemSet>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSet.NativeMethodInfoPtr__ctor_Public_Void_List_1_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EA7 RID: 11943 RVA: 0x001056B4 File Offset: 0x001038B4
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 130334, RefRangeEnd = 130358, XrefRangeStart = 130313, XrefRangeEnd = 130334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemSet(List<ItemSlot> itemSlots) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemSet>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemSlots);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSet.NativeMethodInfoPtr__ctor_Public_Void_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EA8 RID: 11944 RVA: 0x00105700 File Offset: 0x00103900
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 130373, RefRangeEnd = 130375, XrefRangeStart = 130358, XrefRangeEnd = 130373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemSet(Il2CppReferenceArray<ItemSlot> itemSlots) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemSet>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemSlots);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSet.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EA9 RID: 11945 RVA: 0x0010574C File Offset: 0x0010394C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 130385, RefRangeEnd = 130389, XrefRangeStart = 130375, XrefRangeEnd = 130385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<ItemInstance> Deserialize(string json)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemSet.NativeMethodInfoPtr_Deserialize_Public_Static_Il2CppReferenceArray_1_ItemInstance_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ItemInstance>>(intPtr3) : null;
		}

		// Token: 0x06002EAA RID: 11946 RVA: 0x000189F1 File Offset: 0x00016BF1
		public ItemSet(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F48 RID: 3912
		// (get) Token: 0x06002EAB RID: 11947 RVA: 0x00105790 File Offset: 0x00103990
		// (set) Token: 0x06002EAC RID: 11948 RVA: 0x000189FA File Offset: 0x00016BFA
		public unsafe Il2CppStringArray Items
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSet.NativeFieldInfoPtr_Items);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemSet.NativeFieldInfoPtr_Items), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001EE0 RID: 7904
		private static readonly IntPtr NativeFieldInfoPtr_Items;

		// Token: 0x04001EE1 RID: 7905
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_ItemData_0;

		// Token: 0x04001EE2 RID: 7906
		private static readonly IntPtr NativeMethodInfoPtr_GetJSON_Public_String_0;

		// Token: 0x04001EE3 RID: 7907
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_ItemInstance_0;

		// Token: 0x04001EE4 RID: 7908
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_ItemSlot_0;

		// Token: 0x04001EE5 RID: 7909
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_ItemSlot_0;

		// Token: 0x04001EE6 RID: 7910
		private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Public_Static_Il2CppReferenceArray_1_ItemInstance_String_0;
	}
}
