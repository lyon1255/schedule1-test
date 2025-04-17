using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x020005B3 RID: 1459
	public class ProductEntry : MonoBehaviour
	{
		// Token: 0x06008022 RID: 32802 RVA: 0x002247E8 File Offset: 0x002229E8
		// Note: this type is marked as 'beforefieldinit'.
		static ProductEntry()
		{
			Il2CppClassPointerStore<ProductEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "ProductEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr);
			ProductEntry.NativeFieldInfoPtr__Definition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, "<Definition>k__BackingField");
			ProductEntry.NativeFieldInfoPtr_SelectedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, "SelectedColor");
			ProductEntry.NativeFieldInfoPtr_DeselectedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, "DeselectedColor");
			ProductEntry.NativeFieldInfoPtr_FavouritedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, "FavouritedColor");
			ProductEntry.NativeFieldInfoPtr_UnfavouritedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, "UnfavouritedColor");
			ProductEntry.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, "Button");
			ProductEntry.NativeFieldInfoPtr_Frame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, "Frame");
			ProductEntry.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, "Icon");
			ProductEntry.NativeFieldInfoPtr_Tick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, "Tick");
			ProductEntry.NativeFieldInfoPtr_Cross = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, "Cross");
			ProductEntry.NativeFieldInfoPtr_Trigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, "Trigger");
			ProductEntry.NativeFieldInfoPtr_FavouriteButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, "FavouriteButton");
			ProductEntry.NativeFieldInfoPtr_FavouriteIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, "FavouriteIcon");
			ProductEntry.NativeFieldInfoPtr_onHovered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, "onHovered");
			ProductEntry.NativeFieldInfoPtr_destroyed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, "destroyed");
			ProductEntry.NativeMethodInfoPtr_get_Definition_Public_get_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, 100679395);
			ProductEntry.NativeMethodInfoPtr_set_Definition_Private_set_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, 100679396);
			ProductEntry.NativeMethodInfoPtr_Initialize_Public_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, 100679397);
			ProductEntry.NativeMethodInfoPtr_Destroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, 100679398);
			ProductEntry.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, 100679399);
			ProductEntry.NativeMethodInfoPtr_Clicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, 100679400);
			ProductEntry.NativeMethodInfoPtr_FavouriteClicked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, 100679401);
			ProductEntry.NativeMethodInfoPtr_ProductListedOrDelisted_Private_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, 100679402);
			ProductEntry.NativeMethodInfoPtr_UpdateListed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, 100679403);
			ProductEntry.NativeMethodInfoPtr_ProductFavouritedOrUnFavourited_Private_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, 100679404);
			ProductEntry.NativeMethodInfoPtr_UpdateFavourited_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, 100679405);
			ProductEntry.NativeMethodInfoPtr_UpdateDiscovered_Public_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, 100679406);
			ProductEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, 100679407);
			ProductEntry.NativeMethodInfoPtr__Initialize_b__18_0_Private_Void_BaseEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr, 100679408);
		}

		// Token: 0x170026BF RID: 9919
		// (get) Token: 0x06008023 RID: 32803 RVA: 0x00224A5C File Offset: 0x00222C5C
		// (set) Token: 0x06008024 RID: 32804 RVA: 0x00224A9C File Offset: 0x00222C9C
		public unsafe ProductDefinition Definition
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17402, RefRangeEnd = 17403, XrefRangeStart = 17402, XrefRangeEnd = 17403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductEntry.NativeMethodInfoPtr_get_Definition_Public_get_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProductDefinition>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductEntry.NativeMethodInfoPtr_set_Definition_Private_set_Void_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008025 RID: 32805 RVA: 0x00224AE0 File Offset: 0x00222CE0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 243948, RefRangeEnd = 243950, XrefRangeStart = 243824, XrefRangeEnd = 243948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(ProductDefinition definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductEntry.NativeMethodInfoPtr_Initialize_Public_Void_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008026 RID: 32806 RVA: 0x00224B24 File Offset: 0x00222D24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 243958, RefRangeEnd = 243959, XrefRangeStart = 243950, XrefRangeEnd = 243958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductEntry.NativeMethodInfoPtr_Destroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008027 RID: 32807 RVA: 0x00224B58 File Offset: 0x00222D58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243959, XrefRangeEnd = 244045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductEntry.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008028 RID: 32808 RVA: 0x00224B8C File Offset: 0x00222D8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244045, XrefRangeEnd = 244052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductEntry.NativeMethodInfoPtr_Clicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008029 RID: 32809 RVA: 0x00224BC0 File Offset: 0x00222DC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244052, XrefRangeEnd = 244068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FavouriteClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductEntry.NativeMethodInfoPtr_FavouriteClicked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600802A RID: 32810 RVA: 0x00224BF4 File Offset: 0x00222DF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244068, XrefRangeEnd = 244073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProductListedOrDelisted(ProductDefinition def)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(def);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductEntry.NativeMethodInfoPtr_ProductListedOrDelisted_Private_Void_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600802B RID: 32811 RVA: 0x00224C38 File Offset: 0x00222E38
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 244092, RefRangeEnd = 244098, XrefRangeStart = 244073, XrefRangeEnd = 244092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateListed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductEntry.NativeMethodInfoPtr_UpdateListed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600802C RID: 32812 RVA: 0x00224C6C File Offset: 0x00222E6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244098, XrefRangeEnd = 244103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProductFavouritedOrUnFavourited(ProductDefinition def)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(def);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductEntry.NativeMethodInfoPtr_ProductFavouritedOrUnFavourited_Private_Void_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600802D RID: 32813 RVA: 0x00224CB0 File Offset: 0x00222EB0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 244118, RefRangeEnd = 244120, XrefRangeStart = 244103, XrefRangeEnd = 244118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateFavourited()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductEntry.NativeMethodInfoPtr_UpdateFavourited_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600802E RID: 32814 RVA: 0x00224CE4 File Offset: 0x00222EE4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 244142, RefRangeEnd = 244145, XrefRangeStart = 244120, XrefRangeEnd = 244142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDiscovered(ProductDefinition def)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(def);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductEntry.NativeMethodInfoPtr_UpdateDiscovered_Public_Void_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600802F RID: 32815 RVA: 0x00224D28 File Offset: 0x00222F28
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductEntry() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductEntry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008030 RID: 32816 RVA: 0x00224D64 File Offset: 0x00222F64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244145, XrefRangeEnd = 244147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Initialize_b__18_0(BaseEventData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductEntry.NativeMethodInfoPtr__Initialize_b__18_0_Private_Void_BaseEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008031 RID: 32817 RVA: 0x0003CBAD File Offset: 0x0003ADAD
		public ProductEntry(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170026B0 RID: 9904
		// (get) Token: 0x06008032 RID: 32818 RVA: 0x00224DA8 File Offset: 0x00222FA8
		// (set) Token: 0x06008033 RID: 32819 RVA: 0x0003CBB6 File Offset: 0x0003ADB6
		public unsafe ProductDefinition _Definition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr__Definition_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr__Definition_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026B1 RID: 9905
		// (get) Token: 0x06008034 RID: 32820 RVA: 0x00224DD8 File Offset: 0x00222FD8
		// (set) Token: 0x06008035 RID: 32821 RVA: 0x0003CBD5 File Offset: 0x0003ADD5
		public unsafe Color SelectedColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_SelectedColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_SelectedColor)) = value;
			}
		}

		// Token: 0x170026B2 RID: 9906
		// (get) Token: 0x06008036 RID: 32822 RVA: 0x00224E00 File Offset: 0x00223000
		// (set) Token: 0x06008037 RID: 32823 RVA: 0x0003CBF0 File Offset: 0x0003ADF0
		public unsafe Color DeselectedColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_DeselectedColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_DeselectedColor)) = value;
			}
		}

		// Token: 0x170026B3 RID: 9907
		// (get) Token: 0x06008038 RID: 32824 RVA: 0x00224E28 File Offset: 0x00223028
		// (set) Token: 0x06008039 RID: 32825 RVA: 0x0003CC0B File Offset: 0x0003AE0B
		public unsafe Color FavouritedColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_FavouritedColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_FavouritedColor)) = value;
			}
		}

		// Token: 0x170026B4 RID: 9908
		// (get) Token: 0x0600803A RID: 32826 RVA: 0x00224E50 File Offset: 0x00223050
		// (set) Token: 0x0600803B RID: 32827 RVA: 0x0003CC26 File Offset: 0x0003AE26
		public unsafe Color UnfavouritedColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_UnfavouritedColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_UnfavouritedColor)) = value;
			}
		}

		// Token: 0x170026B5 RID: 9909
		// (get) Token: 0x0600803C RID: 32828 RVA: 0x00224E78 File Offset: 0x00223078
		// (set) Token: 0x0600803D RID: 32829 RVA: 0x0003CC41 File Offset: 0x0003AE41
		public unsafe Button Button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_Button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026B6 RID: 9910
		// (get) Token: 0x0600803E RID: 32830 RVA: 0x00224EA8 File Offset: 0x002230A8
		// (set) Token: 0x0600803F RID: 32831 RVA: 0x0003CC60 File Offset: 0x0003AE60
		public unsafe Image Frame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_Frame);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_Frame), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026B7 RID: 9911
		// (get) Token: 0x06008040 RID: 32832 RVA: 0x00224ED8 File Offset: 0x002230D8
		// (set) Token: 0x06008041 RID: 32833 RVA: 0x0003CC7F File Offset: 0x0003AE7F
		public unsafe Image Icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_Icon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026B8 RID: 9912
		// (get) Token: 0x06008042 RID: 32834 RVA: 0x00224F08 File Offset: 0x00223108
		// (set) Token: 0x06008043 RID: 32835 RVA: 0x0003CC9E File Offset: 0x0003AE9E
		public unsafe RectTransform Tick
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_Tick);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_Tick), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026B9 RID: 9913
		// (get) Token: 0x06008044 RID: 32836 RVA: 0x00224F38 File Offset: 0x00223138
		// (set) Token: 0x06008045 RID: 32837 RVA: 0x0003CCBD File Offset: 0x0003AEBD
		public unsafe RectTransform Cross
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_Cross);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_Cross), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026BA RID: 9914
		// (get) Token: 0x06008046 RID: 32838 RVA: 0x00224F68 File Offset: 0x00223168
		// (set) Token: 0x06008047 RID: 32839 RVA: 0x0003CCDC File Offset: 0x0003AEDC
		public unsafe EventTrigger Trigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_Trigger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventTrigger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_Trigger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026BB RID: 9915
		// (get) Token: 0x06008048 RID: 32840 RVA: 0x00224F98 File Offset: 0x00223198
		// (set) Token: 0x06008049 RID: 32841 RVA: 0x0003CCFB File Offset: 0x0003AEFB
		public unsafe Button FavouriteButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_FavouriteButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_FavouriteButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026BC RID: 9916
		// (get) Token: 0x0600804A RID: 32842 RVA: 0x00224FC8 File Offset: 0x002231C8
		// (set) Token: 0x0600804B RID: 32843 RVA: 0x0003CD1A File Offset: 0x0003AF1A
		public unsafe Image FavouriteIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_FavouriteIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_FavouriteIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026BD RID: 9917
		// (get) Token: 0x0600804C RID: 32844 RVA: 0x00224FF8 File Offset: 0x002231F8
		// (set) Token: 0x0600804D RID: 32845 RVA: 0x0003CD39 File Offset: 0x0003AF39
		public unsafe UnityEvent onHovered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_onHovered);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_onHovered), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026BE RID: 9918
		// (get) Token: 0x0600804E RID: 32846 RVA: 0x00225028 File Offset: 0x00223228
		// (set) Token: 0x0600804F RID: 32847 RVA: 0x0003CD58 File Offset: 0x0003AF58
		public unsafe bool destroyed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_destroyed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductEntry.NativeFieldInfoPtr_destroyed)) = value;
			}
		}

		// Token: 0x0400574C RID: 22348
		private static readonly IntPtr NativeFieldInfoPtr__Definition_k__BackingField;

		// Token: 0x0400574D RID: 22349
		private static readonly IntPtr NativeFieldInfoPtr_SelectedColor;

		// Token: 0x0400574E RID: 22350
		private static readonly IntPtr NativeFieldInfoPtr_DeselectedColor;

		// Token: 0x0400574F RID: 22351
		private static readonly IntPtr NativeFieldInfoPtr_FavouritedColor;

		// Token: 0x04005750 RID: 22352
		private static readonly IntPtr NativeFieldInfoPtr_UnfavouritedColor;

		// Token: 0x04005751 RID: 22353
		private static readonly IntPtr NativeFieldInfoPtr_Button;

		// Token: 0x04005752 RID: 22354
		private static readonly IntPtr NativeFieldInfoPtr_Frame;

		// Token: 0x04005753 RID: 22355
		private static readonly IntPtr NativeFieldInfoPtr_Icon;

		// Token: 0x04005754 RID: 22356
		private static readonly IntPtr NativeFieldInfoPtr_Tick;

		// Token: 0x04005755 RID: 22357
		private static readonly IntPtr NativeFieldInfoPtr_Cross;

		// Token: 0x04005756 RID: 22358
		private static readonly IntPtr NativeFieldInfoPtr_Trigger;

		// Token: 0x04005757 RID: 22359
		private static readonly IntPtr NativeFieldInfoPtr_FavouriteButton;

		// Token: 0x04005758 RID: 22360
		private static readonly IntPtr NativeFieldInfoPtr_FavouriteIcon;

		// Token: 0x04005759 RID: 22361
		private static readonly IntPtr NativeFieldInfoPtr_onHovered;

		// Token: 0x0400575A RID: 22362
		private static readonly IntPtr NativeFieldInfoPtr_destroyed;

		// Token: 0x0400575B RID: 22363
		private static readonly IntPtr NativeMethodInfoPtr_get_Definition_Public_get_ProductDefinition_0;

		// Token: 0x0400575C RID: 22364
		private static readonly IntPtr NativeMethodInfoPtr_set_Definition_Private_set_Void_ProductDefinition_0;

		// Token: 0x0400575D RID: 22365
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_ProductDefinition_0;

		// Token: 0x0400575E RID: 22366
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Void_0;

		// Token: 0x0400575F RID: 22367
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04005760 RID: 22368
		private static readonly IntPtr NativeMethodInfoPtr_Clicked_Private_Void_0;

		// Token: 0x04005761 RID: 22369
		private static readonly IntPtr NativeMethodInfoPtr_FavouriteClicked_Private_Void_0;

		// Token: 0x04005762 RID: 22370
		private static readonly IntPtr NativeMethodInfoPtr_ProductListedOrDelisted_Private_Void_ProductDefinition_0;

		// Token: 0x04005763 RID: 22371
		private static readonly IntPtr NativeMethodInfoPtr_UpdateListed_Public_Void_0;

		// Token: 0x04005764 RID: 22372
		private static readonly IntPtr NativeMethodInfoPtr_ProductFavouritedOrUnFavourited_Private_Void_ProductDefinition_0;

		// Token: 0x04005765 RID: 22373
		private static readonly IntPtr NativeMethodInfoPtr_UpdateFavourited_Public_Void_0;

		// Token: 0x04005766 RID: 22374
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDiscovered_Public_Void_ProductDefinition_0;

		// Token: 0x04005767 RID: 22375
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005768 RID: 22376
		private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__18_0_Private_Void_BaseEventData_0;
	}
}
