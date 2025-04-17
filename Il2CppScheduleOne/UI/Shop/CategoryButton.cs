using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Shop
{
	// Token: 0x02000707 RID: 1799
	public class CategoryButton : MonoBehaviour
	{
		// Token: 0x0600A1AD RID: 41389 RVA: 0x0028A8C4 File Offset: 0x00288AC4
		// Note: this type is marked as 'beforefieldinit'.
		static CategoryButton()
		{
			Il2CppClassPointerStore<CategoryButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Shop", "CategoryButton");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CategoryButton>.NativeClassPtr);
			CategoryButton.NativeFieldInfoPtr__isSelected_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CategoryButton>.NativeClassPtr, "<isSelected>k__BackingField");
			CategoryButton.NativeFieldInfoPtr_Category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CategoryButton>.NativeClassPtr, "Category");
			CategoryButton.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CategoryButton>.NativeClassPtr, "button");
			CategoryButton.NativeFieldInfoPtr_shop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CategoryButton>.NativeClassPtr, "shop");
			CategoryButton.NativeMethodInfoPtr_get_isSelected_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CategoryButton>.NativeClassPtr, 100683080);
			CategoryButton.NativeMethodInfoPtr_set_isSelected_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CategoryButton>.NativeClassPtr, 100683081);
			CategoryButton.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CategoryButton>.NativeClassPtr, 100683082);
			CategoryButton.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CategoryButton>.NativeClassPtr, 100683083);
			CategoryButton.NativeMethodInfoPtr_Clicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CategoryButton>.NativeClassPtr, 100683084);
			CategoryButton.NativeMethodInfoPtr_Deselect_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CategoryButton>.NativeClassPtr, 100683085);
			CategoryButton.NativeMethodInfoPtr_Select_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CategoryButton>.NativeClassPtr, 100683086);
			CategoryButton.NativeMethodInfoPtr_RefreshUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CategoryButton>.NativeClassPtr, 100683087);
			CategoryButton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CategoryButton>.NativeClassPtr, 100683088);
		}

		// Token: 0x170031D8 RID: 12760
		// (get) Token: 0x0600A1AE RID: 41390 RVA: 0x0028A9F8 File Offset: 0x00288BF8
		// (set) Token: 0x0600A1AF RID: 41391 RVA: 0x0028AA34 File Offset: 0x00288C34
		public unsafe bool isSelected
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35361, RefRangeEnd = 35362, XrefRangeStart = 35361, XrefRangeEnd = 35362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CategoryButton.NativeMethodInfoPtr_get_isSelected_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 35362, RefRangeEnd = 35364, XrefRangeStart = 35362, XrefRangeEnd = 35364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CategoryButton.NativeMethodInfoPtr_set_isSelected_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600A1B0 RID: 41392 RVA: 0x0028AA74 File Offset: 0x00288C74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283885, XrefRangeEnd = 283902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CategoryButton.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1B1 RID: 41393 RVA: 0x0028AAA8 File Offset: 0x00288CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283902, XrefRangeEnd = 283907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CategoryButton.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1B2 RID: 41394 RVA: 0x0028AADC File Offset: 0x00288CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283907, XrefRangeEnd = 283910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CategoryButton.NativeMethodInfoPtr_Clicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1B3 RID: 41395 RVA: 0x0028AB10 File Offset: 0x00288D10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283910, XrefRangeEnd = 283912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Deselect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CategoryButton.NativeMethodInfoPtr_Deselect_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1B4 RID: 41396 RVA: 0x0028AB44 File Offset: 0x00288D44
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 283924, RefRangeEnd = 283927, XrefRangeStart = 283912, XrefRangeEnd = 283924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Select()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CategoryButton.NativeMethodInfoPtr_Select_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1B5 RID: 41397 RVA: 0x0028AB78 File Offset: 0x00288D78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283927, XrefRangeEnd = 283929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CategoryButton.NativeMethodInfoPtr_RefreshUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1B6 RID: 41398 RVA: 0x0028ABAC File Offset: 0x00288DAC
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CategoryButton() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CategoryButton>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CategoryButton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1B7 RID: 41399 RVA: 0x0004F8AD File Offset: 0x0004DAAD
		public CategoryButton(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170031D4 RID: 12756
		// (get) Token: 0x0600A1B8 RID: 41400 RVA: 0x0028ABE8 File Offset: 0x00288DE8
		// (set) Token: 0x0600A1B9 RID: 41401 RVA: 0x0004F8B6 File Offset: 0x0004DAB6
		public unsafe bool _isSelected_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CategoryButton.NativeFieldInfoPtr__isSelected_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CategoryButton.NativeFieldInfoPtr__isSelected_k__BackingField)) = value;
			}
		}

		// Token: 0x170031D5 RID: 12757
		// (get) Token: 0x0600A1BA RID: 41402 RVA: 0x0028AC10 File Offset: 0x00288E10
		// (set) Token: 0x0600A1BB RID: 41403 RVA: 0x0004F8D1 File Offset: 0x0004DAD1
		public unsafe EShopCategory Category
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CategoryButton.NativeFieldInfoPtr_Category);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CategoryButton.NativeFieldInfoPtr_Category)) = value;
			}
		}

		// Token: 0x170031D6 RID: 12758
		// (get) Token: 0x0600A1BC RID: 41404 RVA: 0x0028AC38 File Offset: 0x00288E38
		// (set) Token: 0x0600A1BD RID: 41405 RVA: 0x0004F8EC File Offset: 0x0004DAEC
		public unsafe Button button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CategoryButton.NativeFieldInfoPtr_button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CategoryButton.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031D7 RID: 12759
		// (get) Token: 0x0600A1BE RID: 41406 RVA: 0x0028AC68 File Offset: 0x00288E68
		// (set) Token: 0x0600A1BF RID: 41407 RVA: 0x0004F90B File Offset: 0x0004DB0B
		public unsafe ShopInterface shop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CategoryButton.NativeFieldInfoPtr_shop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopInterface>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CategoryButton.NativeFieldInfoPtr_shop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006C64 RID: 27748
		private static readonly IntPtr NativeFieldInfoPtr__isSelected_k__BackingField;

		// Token: 0x04006C65 RID: 27749
		private static readonly IntPtr NativeFieldInfoPtr_Category;

		// Token: 0x04006C66 RID: 27750
		private static readonly IntPtr NativeFieldInfoPtr_button;

		// Token: 0x04006C67 RID: 27751
		private static readonly IntPtr NativeFieldInfoPtr_shop;

		// Token: 0x04006C68 RID: 27752
		private static readonly IntPtr NativeMethodInfoPtr_get_isSelected_Public_get_Boolean_0;

		// Token: 0x04006C69 RID: 27753
		private static readonly IntPtr NativeMethodInfoPtr_set_isSelected_Protected_set_Void_Boolean_0;

		// Token: 0x04006C6A RID: 27754
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04006C6B RID: 27755
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04006C6C RID: 27756
		private static readonly IntPtr NativeMethodInfoPtr_Clicked_Private_Void_0;

		// Token: 0x04006C6D RID: 27757
		private static readonly IntPtr NativeMethodInfoPtr_Deselect_Public_Void_0;

		// Token: 0x04006C6E RID: 27758
		private static readonly IntPtr NativeMethodInfoPtr_Select_Public_Void_0;

		// Token: 0x04006C6F RID: 27759
		private static readonly IntPtr NativeMethodInfoPtr_RefreshUI_Private_Void_0;

		// Token: 0x04006C70 RID: 27760
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
