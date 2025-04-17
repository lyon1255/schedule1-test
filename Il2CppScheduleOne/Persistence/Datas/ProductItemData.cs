using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000269 RID: 617
	[Serializable]
	public class ProductItemData : QualityItemData
	{
		// Token: 0x06002F39 RID: 12089 RVA: 0x0010704C File Offset: 0x0010524C
		// Note: this type is marked as 'beforefieldinit'.
		static ProductItemData()
		{
			Il2CppClassPointerStore<ProductItemData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "ProductItemData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductItemData>.NativeClassPtr);
			ProductItemData.NativeFieldInfoPtr_PackagingID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductItemData>.NativeClassPtr, "PackagingID");
			ProductItemData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductItemData>.NativeClassPtr, 100668764);
		}

		// Token: 0x06002F3A RID: 12090 RVA: 0x001070A4 File Offset: 0x001052A4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 130598, RefRangeEnd = 130602, XrefRangeStart = 130598, XrefRangeEnd = 130602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductItemData(string iD, int quantity, string quality, string packagingID) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductItemData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(iD);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(quality);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(packagingID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductItemData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F3B RID: 12091 RVA: 0x00018FC8 File Offset: 0x000171C8
		public ProductItemData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F71 RID: 3953
		// (get) Token: 0x06002F3C RID: 12092 RVA: 0x00107124 File Offset: 0x00105324
		// (set) Token: 0x06002F3D RID: 12093 RVA: 0x00018FD1 File Offset: 0x000171D1
		public unsafe string PackagingID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductItemData.NativeFieldInfoPtr_PackagingID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductItemData.NativeFieldInfoPtr_PackagingID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001F2B RID: 7979
		private static readonly IntPtr NativeFieldInfoPtr_PackagingID;

		// Token: 0x04001F2C RID: 7980
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_String_String_0;
	}
}
