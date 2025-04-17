using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Items
{
	// Token: 0x02000718 RID: 1816
	public class ItemUI : MonoBehaviour
	{
		// Token: 0x0600A34A RID: 41802 RVA: 0x0028FA38 File Offset: 0x0028DC38
		// Note: this type is marked as 'beforefieldinit'.
		static ItemUI()
		{
			Il2CppClassPointerStore<ItemUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Items", "ItemUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemUI>.NativeClassPtr);
			ItemUI.NativeFieldInfoPtr_itemInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUI>.NativeClassPtr, "itemInstance");
			ItemUI.NativeFieldInfoPtr_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUI>.NativeClassPtr, "Rect");
			ItemUI.NativeFieldInfoPtr_IconImg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUI>.NativeClassPtr, "IconImg");
			ItemUI.NativeFieldInfoPtr_QuantityLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUI>.NativeClassPtr, "QuantityLabel");
			ItemUI.NativeFieldInfoPtr_DisplayedQuantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUI>.NativeClassPtr, "DisplayedQuantity");
			ItemUI.NativeFieldInfoPtr_Destroyed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUI>.NativeClassPtr, "Destroyed");
			ItemUI.NativeMethodInfoPtr_Setup_Public_Virtual_New_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUI>.NativeClassPtr, 100683270);
			ItemUI.NativeMethodInfoPtr_Destroy_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUI>.NativeClassPtr, 100683271);
			ItemUI.NativeMethodInfoPtr_DuplicateIcon_Public_Virtual_New_RectTransform_Transform_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUI>.NativeClassPtr, 100683272);
			ItemUI.NativeMethodInfoPtr_SetVisible_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUI>.NativeClassPtr, 100683273);
			ItemUI.NativeMethodInfoPtr_UpdateUI_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUI>.NativeClassPtr, 100683274);
			ItemUI.NativeMethodInfoPtr_SetDisplayedQuantity_Public_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUI>.NativeClassPtr, 100683275);
			ItemUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUI>.NativeClassPtr, 100683276);
		}

		// Token: 0x0600A34B RID: 41803 RVA: 0x0028FB6C File Offset: 0x0028DD6C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 285653, RefRangeEnd = 285658, XrefRangeStart = 285624, XrefRangeEnd = 285653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Setup(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemUI.NativeMethodInfoPtr_Setup_Public_Virtual_New_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A34C RID: 41804 RVA: 0x0028FBBC File Offset: 0x0028DDBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285658, XrefRangeEnd = 285676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemUI.NativeMethodInfoPtr_Destroy_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A34D RID: 41805 RVA: 0x0028FBF8 File Offset: 0x0028DDF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285676, XrefRangeEnd = 285689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual RectTransform DuplicateIcon(Transform parent, int overriddenQuantity = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overriddenQuantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemUI.NativeMethodInfoPtr_DuplicateIcon_Public_Virtual_New_RectTransform_Transform_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
		}

		// Token: 0x0600A34E RID: 41806 RVA: 0x0028FC64 File Offset: 0x0028DE64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285689, XrefRangeEnd = 285692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetVisible(bool vis)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref vis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemUI.NativeMethodInfoPtr_SetVisible_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A34F RID: 41807 RVA: 0x0028FCB0 File Offset: 0x0028DEB0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 285693, RefRangeEnd = 285699, XrefRangeStart = 285692, XrefRangeEnd = 285693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemUI.NativeMethodInfoPtr_UpdateUI_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A350 RID: 41808 RVA: 0x0028FCEC File Offset: 0x0028DEEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285699, XrefRangeEnd = 285702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetDisplayedQuantity(int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemUI.NativeMethodInfoPtr_SetDisplayedQuantity_Public_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A351 RID: 41809 RVA: 0x0028FD38 File Offset: 0x0028DF38
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A352 RID: 41810 RVA: 0x0005064A File Offset: 0x0004E84A
		public ItemUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700325C RID: 12892
		// (get) Token: 0x0600A353 RID: 41811 RVA: 0x0028FD74 File Offset: 0x0028DF74
		// (set) Token: 0x0600A354 RID: 41812 RVA: 0x00050653 File Offset: 0x0004E853
		public unsafe ItemInstance itemInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI.NativeFieldInfoPtr_itemInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI.NativeFieldInfoPtr_itemInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700325D RID: 12893
		// (get) Token: 0x0600A355 RID: 41813 RVA: 0x0028FDA4 File Offset: 0x0028DFA4
		// (set) Token: 0x0600A356 RID: 41814 RVA: 0x00050672 File Offset: 0x0004E872
		public unsafe RectTransform Rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI.NativeFieldInfoPtr_Rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI.NativeFieldInfoPtr_Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700325E RID: 12894
		// (get) Token: 0x0600A357 RID: 41815 RVA: 0x0028FDD4 File Offset: 0x0028DFD4
		// (set) Token: 0x0600A358 RID: 41816 RVA: 0x00050691 File Offset: 0x0004E891
		public unsafe Image IconImg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI.NativeFieldInfoPtr_IconImg);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI.NativeFieldInfoPtr_IconImg), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700325F RID: 12895
		// (get) Token: 0x0600A359 RID: 41817 RVA: 0x0028FE04 File Offset: 0x0028E004
		// (set) Token: 0x0600A35A RID: 41818 RVA: 0x000506B0 File Offset: 0x0004E8B0
		public unsafe TextMeshProUGUI QuantityLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI.NativeFieldInfoPtr_QuantityLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI.NativeFieldInfoPtr_QuantityLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003260 RID: 12896
		// (get) Token: 0x0600A35B RID: 41819 RVA: 0x0028FE34 File Offset: 0x0028E034
		// (set) Token: 0x0600A35C RID: 41820 RVA: 0x000506CF File Offset: 0x0004E8CF
		public unsafe int DisplayedQuantity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI.NativeFieldInfoPtr_DisplayedQuantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI.NativeFieldInfoPtr_DisplayedQuantity)) = value;
			}
		}

		// Token: 0x17003261 RID: 12897
		// (get) Token: 0x0600A35D RID: 41821 RVA: 0x0028FE5C File Offset: 0x0028E05C
		// (set) Token: 0x0600A35E RID: 41822 RVA: 0x000506EA File Offset: 0x0004E8EA
		public unsafe bool Destroyed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI.NativeFieldInfoPtr_Destroyed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI.NativeFieldInfoPtr_Destroyed)) = value;
			}
		}

		// Token: 0x04006D82 RID: 28034
		private static readonly IntPtr NativeFieldInfoPtr_itemInstance;

		// Token: 0x04006D83 RID: 28035
		private static readonly IntPtr NativeFieldInfoPtr_Rect;

		// Token: 0x04006D84 RID: 28036
		private static readonly IntPtr NativeFieldInfoPtr_IconImg;

		// Token: 0x04006D85 RID: 28037
		private static readonly IntPtr NativeFieldInfoPtr_QuantityLabel;

		// Token: 0x04006D86 RID: 28038
		private static readonly IntPtr NativeFieldInfoPtr_DisplayedQuantity;

		// Token: 0x04006D87 RID: 28039
		private static readonly IntPtr NativeFieldInfoPtr_Destroyed;

		// Token: 0x04006D88 RID: 28040
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Virtual_New_Void_ItemInstance_0;

		// Token: 0x04006D89 RID: 28041
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Virtual_New_Void_0;

		// Token: 0x04006D8A RID: 28042
		private static readonly IntPtr NativeMethodInfoPtr_DuplicateIcon_Public_Virtual_New_RectTransform_Transform_Int32_0;

		// Token: 0x04006D8B RID: 28043
		private static readonly IntPtr NativeMethodInfoPtr_SetVisible_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04006D8C RID: 28044
		private static readonly IntPtr NativeMethodInfoPtr_UpdateUI_Public_Virtual_New_Void_0;

		// Token: 0x04006D8D RID: 28045
		private static readonly IntPtr NativeMethodInfoPtr_SetDisplayedQuantity_Public_Virtual_New_Void_Int32_0;

		// Token: 0x04006D8E RID: 28046
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
