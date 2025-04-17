using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Storage;

namespace Il2CppScheduleOne.Clothing
{
	// Token: 0x02000499 RID: 1177
	[Serializable]
	public class ClothingInstance : StorableItemInstance
	{
		// Token: 0x06006631 RID: 26161 RVA: 0x001CC098 File Offset: 0x001CA298
		// Note: this type is marked as 'beforefieldinit'.
		static ClothingInstance()
		{
			Il2CppClassPointerStore<ClothingInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Clothing", "ClothingInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothingInstance>.NativeClassPtr);
			ClothingInstance.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingInstance>.NativeClassPtr, "Color");
			ClothingInstance.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingInstance>.NativeClassPtr, 100676212);
			ClothingInstance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingInstance>.NativeClassPtr, 100676213);
			ClothingInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_EClothingColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingInstance>.NativeClassPtr, 100676214);
			ClothingInstance.NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingInstance>.NativeClassPtr, 100676215);
			ClothingInstance.NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingInstance>.NativeClassPtr, 100676216);
		}

		// Token: 0x17001EC7 RID: 7879
		// (get) Token: 0x06006632 RID: 26162 RVA: 0x001CC140 File Offset: 0x001CA340
		public unsafe override string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206601, XrefRangeEnd = 206614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClothingInstance.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06006633 RID: 26163 RVA: 0x001CC184 File Offset: 0x001CA384
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 206615, RefRangeEnd = 206617, XrefRangeStart = 206614, XrefRangeEnd = 206615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClothingInstance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClothingInstance>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingInstance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006634 RID: 26164 RVA: 0x001CC1C0 File Offset: 0x001CA3C0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 206618, RefRangeEnd = 206623, XrefRangeStart = 206617, XrefRangeEnd = 206618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClothingInstance(ItemDefinition definition, int quantity, EClothingColor color) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClothingInstance>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_EClothingColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006635 RID: 26165 RVA: 0x001CC228 File Offset: 0x001CA428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206623, XrefRangeEnd = 206628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref overrideQuantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClothingInstance.NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x06006636 RID: 26166 RVA: 0x001CC280 File Offset: 0x001CA480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206628, XrefRangeEnd = 206632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemData GetItemData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClothingInstance.NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemData>(intPtr3) : null;
		}

		// Token: 0x06006637 RID: 26167 RVA: 0x0003058A File Offset: 0x0002E78A
		public ClothingInstance(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001EC6 RID: 7878
		// (get) Token: 0x06006638 RID: 26168 RVA: 0x001CC2CC File Offset: 0x001CA4CC
		// (set) Token: 0x06006639 RID: 26169 RVA: 0x00030593 File Offset: 0x0002E793
		public unsafe EClothingColor Color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingInstance.NativeFieldInfoPtr_Color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingInstance.NativeFieldInfoPtr_Color)) = value;
			}
		}

		// Token: 0x040045BD RID: 17853
		private static readonly IntPtr NativeFieldInfoPtr_Color;

		// Token: 0x040045BE RID: 17854
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

		// Token: 0x040045BF RID: 17855
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040045C0 RID: 17856
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_EClothingColor_0;

		// Token: 0x040045C1 RID: 17857
		private static readonly IntPtr NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x040045C2 RID: 17858
		private static readonly IntPtr NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0;
	}
}
