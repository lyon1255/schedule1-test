using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Items
{
	// Token: 0x0200071C RID: 1820
	public class QualityItemUI : ItemUI
	{
		// Token: 0x0600A3BD RID: 41917 RVA: 0x00291098 File Offset: 0x0028F298
		// Note: this type is marked as 'beforefieldinit'.
		static QualityItemUI()
		{
			Il2CppClassPointerStore<QualityItemUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Items", "QualityItemUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QualityItemUI>.NativeClassPtr);
			QualityItemUI.NativeFieldInfoPtr_QualityIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QualityItemUI>.NativeClassPtr, "QualityIcon");
			QualityItemUI.NativeFieldInfoPtr_qualityItemInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QualityItemUI>.NativeClassPtr, "qualityItemInstance");
			QualityItemUI.NativeMethodInfoPtr_Setup_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityItemUI>.NativeClassPtr, 100683315);
			QualityItemUI.NativeMethodInfoPtr_UpdateUI_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityItemUI>.NativeClassPtr, 100683316);
			QualityItemUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityItemUI>.NativeClassPtr, 100683317);
		}

		// Token: 0x0600A3BE RID: 41918 RVA: 0x0029112C File Offset: 0x0028F32C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286378, XrefRangeEnd = 286386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Setup(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QualityItemUI.NativeMethodInfoPtr_Setup_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A3BF RID: 41919 RVA: 0x0029117C File Offset: 0x0028F37C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286386, XrefRangeEnd = 286392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QualityItemUI.NativeMethodInfoPtr_UpdateUI_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A3C0 RID: 41920 RVA: 0x002911B8 File Offset: 0x0028F3B8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QualityItemUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QualityItemUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityItemUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A3C1 RID: 41921 RVA: 0x00050A87 File Offset: 0x0004EC87
		public QualityItemUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003282 RID: 12930
		// (get) Token: 0x0600A3C2 RID: 41922 RVA: 0x002911F4 File Offset: 0x0028F3F4
		// (set) Token: 0x0600A3C3 RID: 41923 RVA: 0x00050A90 File Offset: 0x0004EC90
		public unsafe Image QualityIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityItemUI.NativeFieldInfoPtr_QualityIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityItemUI.NativeFieldInfoPtr_QualityIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003283 RID: 12931
		// (get) Token: 0x0600A3C4 RID: 41924 RVA: 0x00291224 File Offset: 0x0028F424
		// (set) Token: 0x0600A3C5 RID: 41925 RVA: 0x00050AAF File Offset: 0x0004ECAF
		public unsafe QualityItemInstance qualityItemInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityItemUI.NativeFieldInfoPtr_qualityItemInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QualityItemInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityItemUI.NativeFieldInfoPtr_qualityItemInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006DCA RID: 28106
		private static readonly IntPtr NativeFieldInfoPtr_QualityIcon;

		// Token: 0x04006DCB RID: 28107
		private static readonly IntPtr NativeFieldInfoPtr_qualityItemInstance;

		// Token: 0x04006DCC RID: 28108
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x04006DCD RID: 28109
		private static readonly IntPtr NativeMethodInfoPtr_UpdateUI_Public_Virtual_Void_0;

		// Token: 0x04006DCE RID: 28110
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
