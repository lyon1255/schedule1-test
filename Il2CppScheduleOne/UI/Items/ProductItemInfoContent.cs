using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;

namespace Il2CppScheduleOne.UI.Items
{
	// Token: 0x0200071A RID: 1818
	public class ProductItemInfoContent : QualityItemInfoContent
	{
		// Token: 0x0600A3AE RID: 41902 RVA: 0x00290DA0 File Offset: 0x0028EFA0
		// Note: this type is marked as 'beforefieldinit'.
		static ProductItemInfoContent()
		{
			Il2CppClassPointerStore<ProductItemInfoContent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Items", "ProductItemInfoContent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductItemInfoContent>.NativeClassPtr);
			ProductItemInfoContent.NativeFieldInfoPtr_PropertyLabels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductItemInfoContent>.NativeClassPtr, "PropertyLabels");
			ProductItemInfoContent.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInfoContent>.NativeClassPtr, 100683310);
			ProductItemInfoContent.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInfoContent>.NativeClassPtr, 100683311);
			ProductItemInfoContent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemInfoContent>.NativeClassPtr, 100683312);
		}

		// Token: 0x0600A3AF RID: 41903 RVA: 0x00290E20 File Offset: 0x0028F020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286314, XrefRangeEnd = 286324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize(ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInfoContent.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A3B0 RID: 41904 RVA: 0x00290E70 File Offset: 0x0028F070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286324, XrefRangeEnd = 286355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize(ItemDefinition definition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductItemInfoContent.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_ItemDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A3B1 RID: 41905 RVA: 0x00290EC0 File Offset: 0x0028F0C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286355, XrefRangeEnd = 286363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductItemInfoContent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductItemInfoContent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductItemInfoContent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A3B2 RID: 41906 RVA: 0x00050A18 File Offset: 0x0004EC18
		public ProductItemInfoContent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700327F RID: 12927
		// (get) Token: 0x0600A3B3 RID: 41907 RVA: 0x00290EFC File Offset: 0x0028F0FC
		// (set) Token: 0x0600A3B4 RID: 41908 RVA: 0x00050A21 File Offset: 0x0004EC21
		public unsafe List<TextMeshProUGUI> PropertyLabels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductItemInfoContent.NativeFieldInfoPtr_PropertyLabels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TextMeshProUGUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductItemInfoContent.NativeFieldInfoPtr_PropertyLabels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006DC2 RID: 28098
		private static readonly IntPtr NativeFieldInfoPtr_PropertyLabels;

		// Token: 0x04006DC3 RID: 28099
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x04006DC4 RID: 28100
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_ItemDefinition_0;

		// Token: 0x04006DC5 RID: 28101
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
