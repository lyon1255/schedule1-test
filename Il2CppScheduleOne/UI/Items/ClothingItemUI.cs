using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Items
{
	// Token: 0x02000713 RID: 1811
	public class ClothingItemUI : ItemUI
	{
		// Token: 0x0600A30A RID: 41738 RVA: 0x0028EEA0 File Offset: 0x0028D0A0
		// Note: this type is marked as 'beforefieldinit'.
		static ClothingItemUI()
		{
			Il2CppClassPointerStore<ClothingItemUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Items", "ClothingItemUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothingItemUI>.NativeClassPtr);
			ClothingItemUI.NativeFieldInfoPtr_ClothingTypeIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingItemUI>.NativeClassPtr, "ClothingTypeIcon");
			ClothingItemUI.NativeMethodInfoPtr_UpdateUI_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingItemUI>.NativeClassPtr, 100683252);
			ClothingItemUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingItemUI>.NativeClassPtr, 100683253);
		}

		// Token: 0x0600A30B RID: 41739 RVA: 0x0028EF0C File Offset: 0x0028D10C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285499, XrefRangeEnd = 285519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClothingItemUI.NativeMethodInfoPtr_UpdateUI_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A30C RID: 41740 RVA: 0x0028EF48 File Offset: 0x0028D148
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClothingItemUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClothingItemUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingItemUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A30D RID: 41741 RVA: 0x0005040C File Offset: 0x0004E60C
		public ClothingItemUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003248 RID: 12872
		// (get) Token: 0x0600A30E RID: 41742 RVA: 0x0028EF84 File Offset: 0x0028D184
		// (set) Token: 0x0600A30F RID: 41743 RVA: 0x00050415 File Offset: 0x0004E615
		public unsafe Image ClothingTypeIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingItemUI.NativeFieldInfoPtr_ClothingTypeIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingItemUI.NativeFieldInfoPtr_ClothingTypeIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006D5E RID: 27998
		private static readonly IntPtr NativeFieldInfoPtr_ClothingTypeIcon;

		// Token: 0x04006D5F RID: 27999
		private static readonly IntPtr NativeMethodInfoPtr_UpdateUI_Public_Virtual_Void_0;

		// Token: 0x04006D60 RID: 28000
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
