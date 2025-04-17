using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.ObjectScripts.WateringCan;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Items
{
	// Token: 0x02000712 RID: 1810
	public class ItemUI_WateringCan : ItemUI
	{
		// Token: 0x0600A301 RID: 41729 RVA: 0x0028ECE4 File Offset: 0x0028CEE4
		// Note: this type is marked as 'beforefieldinit'.
		static ItemUI_WateringCan()
		{
			Il2CppClassPointerStore<ItemUI_WateringCan>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Items", "ItemUI_WateringCan");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemUI_WateringCan>.NativeClassPtr);
			ItemUI_WateringCan.NativeFieldInfoPtr_wcInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUI_WateringCan>.NativeClassPtr, "wcInstance");
			ItemUI_WateringCan.NativeFieldInfoPtr_AmountLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUI_WateringCan>.NativeClassPtr, "AmountLabel");
			ItemUI_WateringCan.NativeMethodInfoPtr_Setup_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUI_WateringCan>.NativeClassPtr, 100683249);
			ItemUI_WateringCan.NativeMethodInfoPtr_UpdateUI_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUI_WateringCan>.NativeClassPtr, 100683250);
			ItemUI_WateringCan.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUI_WateringCan>.NativeClassPtr, 100683251);
		}

		// Token: 0x0600A302 RID: 41730 RVA: 0x0028ED78 File Offset: 0x0028CF78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285485, XrefRangeEnd = 285493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Setup(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemUI_WateringCan.NativeMethodInfoPtr_Setup_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A303 RID: 41731 RVA: 0x0028EDC8 File Offset: 0x0028CFC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285493, XrefRangeEnd = 285499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemUI_WateringCan.NativeMethodInfoPtr_UpdateUI_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A304 RID: 41732 RVA: 0x0028EE04 File Offset: 0x0028D004
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemUI_WateringCan() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemUI_WateringCan>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUI_WateringCan.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A305 RID: 41733 RVA: 0x000503C5 File Offset: 0x0004E5C5
		public ItemUI_WateringCan(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003246 RID: 12870
		// (get) Token: 0x0600A306 RID: 41734 RVA: 0x0028EE40 File Offset: 0x0028D040
		// (set) Token: 0x0600A307 RID: 41735 RVA: 0x000503CE File Offset: 0x0004E5CE
		public unsafe WateringCanInstance wcInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI_WateringCan.NativeFieldInfoPtr_wcInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WateringCanInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI_WateringCan.NativeFieldInfoPtr_wcInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003247 RID: 12871
		// (get) Token: 0x0600A308 RID: 41736 RVA: 0x0028EE70 File Offset: 0x0028D070
		// (set) Token: 0x0600A309 RID: 41737 RVA: 0x000503ED File Offset: 0x0004E5ED
		public unsafe Text AmountLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI_WateringCan.NativeFieldInfoPtr_AmountLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI_WateringCan.NativeFieldInfoPtr_AmountLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006D59 RID: 27993
		private static readonly IntPtr NativeFieldInfoPtr_wcInstance;

		// Token: 0x04006D5A RID: 27994
		private static readonly IntPtr NativeFieldInfoPtr_AmountLabel;

		// Token: 0x04006D5B RID: 27995
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x04006D5C RID: 27996
		private static readonly IntPtr NativeMethodInfoPtr_UpdateUI_Public_Virtual_Void_0;

		// Token: 0x04006D5D RID: 27997
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
