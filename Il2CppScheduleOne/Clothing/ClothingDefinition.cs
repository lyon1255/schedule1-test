using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Clothing
{
	// Token: 0x02000498 RID: 1176
	[Serializable]
	public class ClothingDefinition : StorableItemDefinition
	{
		// Token: 0x06006621 RID: 26145 RVA: 0x001CBE3C File Offset: 0x001CA03C
		// Note: this type is marked as 'beforefieldinit'.
		static ClothingDefinition()
		{
			Il2CppClassPointerStore<ClothingDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Clothing", "ClothingDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothingDefinition>.NativeClassPtr);
			ClothingDefinition.NativeFieldInfoPtr_Slot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingDefinition>.NativeClassPtr, "Slot");
			ClothingDefinition.NativeFieldInfoPtr_ApplicationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingDefinition>.NativeClassPtr, "ApplicationType");
			ClothingDefinition.NativeFieldInfoPtr_ClothingAssetPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingDefinition>.NativeClassPtr, "ClothingAssetPath");
			ClothingDefinition.NativeFieldInfoPtr_Colorable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingDefinition>.NativeClassPtr, "Colorable");
			ClothingDefinition.NativeFieldInfoPtr_DefaultColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingDefinition>.NativeClassPtr, "DefaultColor");
			ClothingDefinition.NativeFieldInfoPtr_SlotsToBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingDefinition>.NativeClassPtr, "SlotsToBlock");
			ClothingDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingDefinition>.NativeClassPtr, 100676210);
			ClothingDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingDefinition>.NativeClassPtr, 100676211);
		}

		// Token: 0x06006622 RID: 26146 RVA: 0x001CBF0C File Offset: 0x001CA10C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206585, XrefRangeEnd = 206589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClothingDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x06006623 RID: 26147 RVA: 0x001CBF64 File Offset: 0x001CA164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206589, XrefRangeEnd = 206601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClothingDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClothingDefinition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006624 RID: 26148 RVA: 0x000304D7 File Offset: 0x0002E6D7
		public ClothingDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001EC0 RID: 7872
		// (get) Token: 0x06006625 RID: 26149 RVA: 0x001CBFA0 File Offset: 0x001CA1A0
		// (set) Token: 0x06006626 RID: 26150 RVA: 0x000304E0 File Offset: 0x0002E6E0
		public unsafe EClothingSlot Slot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingDefinition.NativeFieldInfoPtr_Slot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingDefinition.NativeFieldInfoPtr_Slot)) = value;
			}
		}

		// Token: 0x17001EC1 RID: 7873
		// (get) Token: 0x06006627 RID: 26151 RVA: 0x001CBFC8 File Offset: 0x001CA1C8
		// (set) Token: 0x06006628 RID: 26152 RVA: 0x000304FB File Offset: 0x0002E6FB
		public unsafe EClothingApplicationType ApplicationType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingDefinition.NativeFieldInfoPtr_ApplicationType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingDefinition.NativeFieldInfoPtr_ApplicationType)) = value;
			}
		}

		// Token: 0x17001EC2 RID: 7874
		// (get) Token: 0x06006629 RID: 26153 RVA: 0x001CBFF0 File Offset: 0x001CA1F0
		// (set) Token: 0x0600662A RID: 26154 RVA: 0x00030516 File Offset: 0x0002E716
		public unsafe string ClothingAssetPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingDefinition.NativeFieldInfoPtr_ClothingAssetPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingDefinition.NativeFieldInfoPtr_ClothingAssetPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001EC3 RID: 7875
		// (get) Token: 0x0600662B RID: 26155 RVA: 0x001CC018 File Offset: 0x001CA218
		// (set) Token: 0x0600662C RID: 26156 RVA: 0x00030535 File Offset: 0x0002E735
		public unsafe bool Colorable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingDefinition.NativeFieldInfoPtr_Colorable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingDefinition.NativeFieldInfoPtr_Colorable)) = value;
			}
		}

		// Token: 0x17001EC4 RID: 7876
		// (get) Token: 0x0600662D RID: 26157 RVA: 0x001CC040 File Offset: 0x001CA240
		// (set) Token: 0x0600662E RID: 26158 RVA: 0x00030550 File Offset: 0x0002E750
		public unsafe EClothingColor DefaultColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingDefinition.NativeFieldInfoPtr_DefaultColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingDefinition.NativeFieldInfoPtr_DefaultColor)) = value;
			}
		}

		// Token: 0x17001EC5 RID: 7877
		// (get) Token: 0x0600662F RID: 26159 RVA: 0x001CC068 File Offset: 0x001CA268
		// (set) Token: 0x06006630 RID: 26160 RVA: 0x0003056B File Offset: 0x0002E76B
		public unsafe List<EClothingSlot> SlotsToBlock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingDefinition.NativeFieldInfoPtr_SlotsToBlock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EClothingSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingDefinition.NativeFieldInfoPtr_SlotsToBlock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040045B5 RID: 17845
		private static readonly IntPtr NativeFieldInfoPtr_Slot;

		// Token: 0x040045B6 RID: 17846
		private static readonly IntPtr NativeFieldInfoPtr_ApplicationType;

		// Token: 0x040045B7 RID: 17847
		private static readonly IntPtr NativeFieldInfoPtr_ClothingAssetPath;

		// Token: 0x040045B8 RID: 17848
		private static readonly IntPtr NativeFieldInfoPtr_Colorable;

		// Token: 0x040045B9 RID: 17849
		private static readonly IntPtr NativeFieldInfoPtr_DefaultColor;

		// Token: 0x040045BA RID: 17850
		private static readonly IntPtr NativeFieldInfoPtr_SlotsToBlock;

		// Token: 0x040045BB RID: 17851
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x040045BC RID: 17852
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
