using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Clothing;
using Il2CppScheduleOne.DevUtilities;

namespace Il2CppScheduleOne.UI.Shop
{
	// Token: 0x02000708 RID: 1800
	public class ClothingShopInterface : ShopInterface
	{
		// Token: 0x0600A1C0 RID: 41408 RVA: 0x0028AC98 File Offset: 0x00288E98
		// Note: this type is marked as 'beforefieldinit'.
		static ClothingShopInterface()
		{
			Il2CppClassPointerStore<ClothingShopInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Shop", "ClothingShopInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothingShopInterface>.NativeClassPtr);
			ClothingShopInterface.NativeFieldInfoPtr_ColorPicker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingShopInterface>.NativeClassPtr, "ColorPicker");
			ClothingShopInterface.NativeFieldInfoPtr__selectedListing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingShopInterface>.NativeClassPtr, "_selectedListing");
			ClothingShopInterface.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingShopInterface>.NativeClassPtr, 100683089);
			ClothingShopInterface.NativeMethodInfoPtr_ListingClicked_Public_Virtual_Void_ListingUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingShopInterface>.NativeClassPtr, 100683090);
			ClothingShopInterface.NativeMethodInfoPtr_Exit_Protected_Virtual_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingShopInterface>.NativeClassPtr, 100683091);
			ClothingShopInterface.NativeMethodInfoPtr_ColorPicked_Private_Void_EClothingColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingShopInterface>.NativeClassPtr, 100683092);
			ClothingShopInterface.NativeMethodInfoPtr_HandoverItems_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingShopInterface>.NativeClassPtr, 100683093);
			ClothingShopInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingShopInterface>.NativeClassPtr, 100683094);
		}

		// Token: 0x0600A1C1 RID: 41409 RVA: 0x0028AD68 File Offset: 0x00288F68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283929, XrefRangeEnd = 283940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClothingShopInterface.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1C2 RID: 41410 RVA: 0x0028ADA4 File Offset: 0x00288FA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283940, XrefRangeEnd = 283947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ListingClicked(ListingUI listingUI)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listingUI);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClothingShopInterface.NativeMethodInfoPtr_ListingClicked_Public_Virtual_Void_ListingUI_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1C3 RID: 41411 RVA: 0x0028ADF4 File Offset: 0x00288FF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283947, XrefRangeEnd = 283955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClothingShopInterface.NativeMethodInfoPtr_Exit_Protected_Virtual_Void_ExitAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1C4 RID: 41412 RVA: 0x0028AE44 File Offset: 0x00289044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283955, XrefRangeEnd = 283961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ColorPicked(EClothingColor color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingShopInterface.NativeMethodInfoPtr_ColorPicked_Private_Void_EClothingColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1C5 RID: 41413 RVA: 0x0028AE84 File Offset: 0x00289084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283961, XrefRangeEnd = 284029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool HandoverItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClothingShopInterface.NativeMethodInfoPtr_HandoverItems_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A1C6 RID: 41414 RVA: 0x0028AECC File Offset: 0x002890CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284029, XrefRangeEnd = 284033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClothingShopInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClothingShopInterface>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingShopInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A1C7 RID: 41415 RVA: 0x0004F92A File Offset: 0x0004DB2A
		public ClothingShopInterface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170031D9 RID: 12761
		// (get) Token: 0x0600A1C8 RID: 41416 RVA: 0x0028AF08 File Offset: 0x00289108
		// (set) Token: 0x0600A1C9 RID: 41417 RVA: 0x0004F933 File Offset: 0x0004DB33
		public unsafe ShopColorPicker ColorPicker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingShopInterface.NativeFieldInfoPtr_ColorPicker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopColorPicker>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingShopInterface.NativeFieldInfoPtr_ColorPicker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031DA RID: 12762
		// (get) Token: 0x0600A1CA RID: 41418 RVA: 0x0028AF38 File Offset: 0x00289138
		// (set) Token: 0x0600A1CB RID: 41419 RVA: 0x0004F952 File Offset: 0x0004DB52
		public unsafe ShopListing _selectedListing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingShopInterface.NativeFieldInfoPtr__selectedListing);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopListing>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingShopInterface.NativeFieldInfoPtr__selectedListing), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006C71 RID: 27761
		private static readonly IntPtr NativeFieldInfoPtr_ColorPicker;

		// Token: 0x04006C72 RID: 27762
		private static readonly IntPtr NativeFieldInfoPtr__selectedListing;

		// Token: 0x04006C73 RID: 27763
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04006C74 RID: 27764
		private static readonly IntPtr NativeMethodInfoPtr_ListingClicked_Public_Virtual_Void_ListingUI_0;

		// Token: 0x04006C75 RID: 27765
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Protected_Virtual_Void_ExitAction_0;

		// Token: 0x04006C76 RID: 27766
		private static readonly IntPtr NativeMethodInfoPtr_ColorPicked_Private_Void_EClothingColor_0;

		// Token: 0x04006C77 RID: 27767
		private static readonly IntPtr NativeMethodInfoPtr_HandoverItems_Public_Virtual_Boolean_0;

		// Token: 0x04006C78 RID: 27768
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
