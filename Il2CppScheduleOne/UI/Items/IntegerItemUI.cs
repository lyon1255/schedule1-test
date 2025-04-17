using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Items
{
	// Token: 0x02000714 RID: 1812
	public class IntegerItemUI : ItemUI
	{
		// Token: 0x0600A310 RID: 41744 RVA: 0x0028EFB4 File Offset: 0x0028D1B4
		// Note: this type is marked as 'beforefieldinit'.
		static IntegerItemUI()
		{
			Il2CppClassPointerStore<IntegerItemUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Items", "IntegerItemUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntegerItemUI>.NativeClassPtr);
			IntegerItemUI.NativeFieldInfoPtr_ValueLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntegerItemUI>.NativeClassPtr, "ValueLabel");
			IntegerItemUI.NativeFieldInfoPtr_integerItemInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntegerItemUI>.NativeClassPtr, "integerItemInstance");
			IntegerItemUI.NativeMethodInfoPtr_Setup_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegerItemUI>.NativeClassPtr, 100683254);
			IntegerItemUI.NativeMethodInfoPtr_UpdateUI_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegerItemUI>.NativeClassPtr, 100683255);
			IntegerItemUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegerItemUI>.NativeClassPtr, 100683256);
		}

		// Token: 0x0600A311 RID: 41745 RVA: 0x0028F048 File Offset: 0x0028D248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285519, XrefRangeEnd = 285527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Setup(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntegerItemUI.NativeMethodInfoPtr_Setup_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A312 RID: 41746 RVA: 0x0028F098 File Offset: 0x0028D298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285527, XrefRangeEnd = 285529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntegerItemUI.NativeMethodInfoPtr_UpdateUI_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A313 RID: 41747 RVA: 0x0028F0D4 File Offset: 0x0028D2D4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntegerItemUI() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntegerItemUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntegerItemUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A314 RID: 41748 RVA: 0x00050434 File Offset: 0x0004E634
		public IntegerItemUI(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003249 RID: 12873
		// (get) Token: 0x0600A315 RID: 41749 RVA: 0x0028F110 File Offset: 0x0028D310
		// (set) Token: 0x0600A316 RID: 41750 RVA: 0x0005043D File Offset: 0x0004E63D
		public unsafe Text ValueLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntegerItemUI.NativeFieldInfoPtr_ValueLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntegerItemUI.NativeFieldInfoPtr_ValueLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700324A RID: 12874
		// (get) Token: 0x0600A317 RID: 41751 RVA: 0x0028F140 File Offset: 0x0028D340
		// (set) Token: 0x0600A318 RID: 41752 RVA: 0x0005045C File Offset: 0x0004E65C
		public unsafe IntegerItemInstance integerItemInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntegerItemUI.NativeFieldInfoPtr_integerItemInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IntegerItemInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntegerItemUI.NativeFieldInfoPtr_integerItemInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006D61 RID: 28001
		private static readonly IntPtr NativeFieldInfoPtr_ValueLabel;

		// Token: 0x04006D62 RID: 28002
		private static readonly IntPtr NativeFieldInfoPtr_integerItemInstance;

		// Token: 0x04006D63 RID: 28003
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x04006D64 RID: 28004
		private static readonly IntPtr NativeMethodInfoPtr_UpdateUI_Public_Virtual_Void_0;

		// Token: 0x04006D65 RID: 28005
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
