using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppTMPro;

namespace Il2CppScheduleOne.UI.Items
{
	// Token: 0x02000711 RID: 1809
	public class ItemUI_Cash : ItemUI
	{
		// Token: 0x0600A2F7 RID: 41719 RVA: 0x0028EAD4 File Offset: 0x0028CCD4
		// Note: this type is marked as 'beforefieldinit'.
		static ItemUI_Cash()
		{
			Il2CppClassPointerStore<ItemUI_Cash>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Items", "ItemUI_Cash");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemUI_Cash>.NativeClassPtr);
			ItemUI_Cash.NativeFieldInfoPtr_cashInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUI_Cash>.NativeClassPtr, "cashInstance");
			ItemUI_Cash.NativeFieldInfoPtr_AmountLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemUI_Cash>.NativeClassPtr, "AmountLabel");
			ItemUI_Cash.NativeMethodInfoPtr_Setup_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUI_Cash>.NativeClassPtr, 100683245);
			ItemUI_Cash.NativeMethodInfoPtr_UpdateUI_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUI_Cash>.NativeClassPtr, 100683246);
			ItemUI_Cash.NativeMethodInfoPtr_SetDisplayedBalance_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUI_Cash>.NativeClassPtr, 100683247);
			ItemUI_Cash.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemUI_Cash>.NativeClassPtr, 100683248);
		}

		// Token: 0x0600A2F8 RID: 41720 RVA: 0x0028EB7C File Offset: 0x0028CD7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285452, XrefRangeEnd = 285460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Setup(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemUI_Cash.NativeMethodInfoPtr_Setup_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A2F9 RID: 41721 RVA: 0x0028EBCC File Offset: 0x0028CDCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 285460, XrefRangeEnd = 285462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemUI_Cash.NativeMethodInfoPtr_UpdateUI_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A2FA RID: 41722 RVA: 0x0028EC08 File Offset: 0x0028CE08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285484, RefRangeEnd = 285485, XrefRangeStart = 285462, XrefRangeEnd = 285484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDisplayedBalance(float balance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref balance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUI_Cash.NativeMethodInfoPtr_SetDisplayedBalance_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A2FB RID: 41723 RVA: 0x0028EC48 File Offset: 0x0028CE48
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemUI_Cash() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemUI_Cash>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemUI_Cash.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A2FC RID: 41724 RVA: 0x0005037E File Offset: 0x0004E57E
		public ItemUI_Cash(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003244 RID: 12868
		// (get) Token: 0x0600A2FD RID: 41725 RVA: 0x0028EC84 File Offset: 0x0028CE84
		// (set) Token: 0x0600A2FE RID: 41726 RVA: 0x00050387 File Offset: 0x0004E587
		public unsafe CashInstance cashInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI_Cash.NativeFieldInfoPtr_cashInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CashInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI_Cash.NativeFieldInfoPtr_cashInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003245 RID: 12869
		// (get) Token: 0x0600A2FF RID: 41727 RVA: 0x0028ECB4 File Offset: 0x0028CEB4
		// (set) Token: 0x0600A300 RID: 41728 RVA: 0x000503A6 File Offset: 0x0004E5A6
		public unsafe TextMeshProUGUI AmountLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI_Cash.NativeFieldInfoPtr_AmountLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemUI_Cash.NativeFieldInfoPtr_AmountLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006D53 RID: 27987
		private static readonly IntPtr NativeFieldInfoPtr_cashInstance;

		// Token: 0x04006D54 RID: 27988
		private static readonly IntPtr NativeFieldInfoPtr_AmountLabel;

		// Token: 0x04006D55 RID: 27989
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x04006D56 RID: 27990
		private static readonly IntPtr NativeMethodInfoPtr_UpdateUI_Public_Virtual_Void_0;

		// Token: 0x04006D57 RID: 27991
		private static readonly IntPtr NativeMethodInfoPtr_SetDisplayedBalance_Public_Void_Single_0;

		// Token: 0x04006D58 RID: 27992
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
