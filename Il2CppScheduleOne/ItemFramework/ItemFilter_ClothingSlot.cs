using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Clothing;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005D7 RID: 1495
	public class ItemFilter_ClothingSlot : ItemFilter
	{
		// Token: 0x0600833C RID: 33596 RVA: 0x0022E34C File Offset: 0x0022C54C
		// Note: this type is marked as 'beforefieldinit'.
		static ItemFilter_ClothingSlot()
		{
			Il2CppClassPointerStore<ItemFilter_ClothingSlot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "ItemFilter_ClothingSlot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemFilter_ClothingSlot>.NativeClassPtr);
			ItemFilter_ClothingSlot.NativeFieldInfoPtr__SlotType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemFilter_ClothingSlot>.NativeClassPtr, "<SlotType>k__BackingField");
			ItemFilter_ClothingSlot.NativeMethodInfoPtr_get_SlotType_Public_get_EClothingSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_ClothingSlot>.NativeClassPtr, 100679712);
			ItemFilter_ClothingSlot.NativeMethodInfoPtr_set_SlotType_Private_set_Void_EClothingSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_ClothingSlot>.NativeClassPtr, 100679713);
			ItemFilter_ClothingSlot.NativeMethodInfoPtr__ctor_Public_Void_EClothingSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_ClothingSlot>.NativeClassPtr, 100679714);
			ItemFilter_ClothingSlot.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemFilter_ClothingSlot>.NativeClassPtr, 100679715);
		}

		// Token: 0x170027B7 RID: 10167
		// (get) Token: 0x0600833D RID: 33597 RVA: 0x0022E3E0 File Offset: 0x0022C5E0
		// (set) Token: 0x0600833E RID: 33598 RVA: 0x0022E41C File Offset: 0x0022C61C
		public unsafe EClothingSlot SlotType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFilter_ClothingSlot.NativeMethodInfoPtr_get_SlotType_Public_get_EClothingSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 29969, RefRangeEnd = 29975, XrefRangeStart = 29969, XrefRangeEnd = 29975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFilter_ClothingSlot.NativeMethodInfoPtr_set_SlotType_Private_set_Void_EClothingSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600833F RID: 33599 RVA: 0x0022E45C File Offset: 0x0022C65C
		[CallerCount(61)]
		[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemFilter_ClothingSlot(EClothingSlot slot) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemFilter_ClothingSlot>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref slot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemFilter_ClothingSlot.NativeMethodInfoPtr__ctor_Public_Void_EClothingSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008340 RID: 33600 RVA: 0x0022E4A4 File Offset: 0x0022C6A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246989, XrefRangeEnd = 247000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool DoesItemMatchFilter(ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemFilter_ClothingSlot.NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008341 RID: 33601 RVA: 0x0003E5B9 File Offset: 0x0003C7B9
		public ItemFilter_ClothingSlot(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170027B6 RID: 10166
		// (get) Token: 0x06008342 RID: 33602 RVA: 0x0022E4FC File Offset: 0x0022C6FC
		// (set) Token: 0x06008343 RID: 33603 RVA: 0x0003E5C2 File Offset: 0x0003C7C2
		public unsafe EClothingSlot _SlotType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFilter_ClothingSlot.NativeFieldInfoPtr__SlotType_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemFilter_ClothingSlot.NativeFieldInfoPtr__SlotType_k__BackingField)) = value;
			}
		}

		// Token: 0x04005955 RID: 22869
		private static readonly IntPtr NativeFieldInfoPtr__SlotType_k__BackingField;

		// Token: 0x04005956 RID: 22870
		private static readonly IntPtr NativeMethodInfoPtr_get_SlotType_Public_get_EClothingSlot_0;

		// Token: 0x04005957 RID: 22871
		private static readonly IntPtr NativeMethodInfoPtr_set_SlotType_Private_set_Void_EClothingSlot_0;

		// Token: 0x04005958 RID: 22872
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EClothingSlot_0;

		// Token: 0x04005959 RID: 22873
		private static readonly IntPtr NativeMethodInfoPtr_DoesItemMatchFilter_Public_Virtual_Boolean_ItemInstance_0;
	}
}
