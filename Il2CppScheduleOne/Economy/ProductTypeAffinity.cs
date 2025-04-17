using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Product;
using Il2CppSystem;

namespace Il2CppScheduleOne.Economy
{
	// Token: 0x0200040D RID: 1037
	[Serializable]
	public class ProductTypeAffinity : Object
	{
		// Token: 0x06005A0C RID: 23052 RVA: 0x001A3300 File Offset: 0x001A1500
		// Note: this type is marked as 'beforefieldinit'.
		static ProductTypeAffinity()
		{
			Il2CppClassPointerStore<ProductTypeAffinity>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Economy", "ProductTypeAffinity");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductTypeAffinity>.NativeClassPtr);
			ProductTypeAffinity.NativeFieldInfoPtr_DrugType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductTypeAffinity>.NativeClassPtr, "DrugType");
			ProductTypeAffinity.NativeFieldInfoPtr_Affinity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductTypeAffinity>.NativeClassPtr, "Affinity");
			ProductTypeAffinity.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductTypeAffinity>.NativeClassPtr, 100674773);
		}

		// Token: 0x06005A0D RID: 23053 RVA: 0x001A336C File Offset: 0x001A156C
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductTypeAffinity() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductTypeAffinity>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductTypeAffinity.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A0E RID: 23054 RVA: 0x0002A83D File Offset: 0x00028A3D
		public ProductTypeAffinity(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001B22 RID: 6946
		// (get) Token: 0x06005A0F RID: 23055 RVA: 0x001A33A8 File Offset: 0x001A15A8
		// (set) Token: 0x06005A10 RID: 23056 RVA: 0x0002A846 File Offset: 0x00028A46
		public unsafe EDrugType DrugType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductTypeAffinity.NativeFieldInfoPtr_DrugType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductTypeAffinity.NativeFieldInfoPtr_DrugType)) = value;
			}
		}

		// Token: 0x17001B23 RID: 6947
		// (get) Token: 0x06005A11 RID: 23057 RVA: 0x001A33D0 File Offset: 0x001A15D0
		// (set) Token: 0x06005A12 RID: 23058 RVA: 0x0002A861 File Offset: 0x00028A61
		public unsafe float Affinity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductTypeAffinity.NativeFieldInfoPtr_Affinity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductTypeAffinity.NativeFieldInfoPtr_Affinity)) = value;
			}
		}

		// Token: 0x04003D81 RID: 15745
		private static readonly IntPtr NativeFieldInfoPtr_DrugType;

		// Token: 0x04003D82 RID: 15746
		private static readonly IntPtr NativeFieldInfoPtr_Affinity;

		// Token: 0x04003D83 RID: 15747
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
