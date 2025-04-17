using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x020005A4 RID: 1444
	[Serializable]
	public class NewMixOperation : Object
	{
		// Token: 0x06007E36 RID: 32310 RVA: 0x0021C408 File Offset: 0x0021A608
		// Note: this type is marked as 'beforefieldinit'.
		static NewMixOperation()
		{
			Il2CppClassPointerStore<NewMixOperation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "NewMixOperation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewMixOperation>.NativeClassPtr);
			NewMixOperation.NativeFieldInfoPtr_ProductID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixOperation>.NativeClassPtr, "ProductID");
			NewMixOperation.NativeFieldInfoPtr_IngredientID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixOperation>.NativeClassPtr, "IngredientID");
			NewMixOperation.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixOperation>.NativeClassPtr, 100679082);
			NewMixOperation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixOperation>.NativeClassPtr, 100679083);
		}

		// Token: 0x06007E37 RID: 32311 RVA: 0x0021C488 File Offset: 0x0021A688
		[CallerCount(49)]
		[CachedScanResults(RefRangeStart = 110661, RefRangeEnd = 110710, XrefRangeStart = 110661, XrefRangeEnd = 110710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NewMixOperation(string productID, string ingredientID) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewMixOperation>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(productID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ingredientID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixOperation.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E38 RID: 32312 RVA: 0x0021C4E8 File Offset: 0x0021A6E8
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NewMixOperation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewMixOperation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixOperation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E39 RID: 32313 RVA: 0x0003BFB5 File Offset: 0x0003A1B5
		public NewMixOperation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700262C RID: 9772
		// (get) Token: 0x06007E3A RID: 32314 RVA: 0x0021C524 File Offset: 0x0021A724
		// (set) Token: 0x06007E3B RID: 32315 RVA: 0x0003BFBE File Offset: 0x0003A1BE
		public unsafe string ProductID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixOperation.NativeFieldInfoPtr_ProductID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixOperation.NativeFieldInfoPtr_ProductID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700262D RID: 9773
		// (get) Token: 0x06007E3C RID: 32316 RVA: 0x0021C54C File Offset: 0x0021A74C
		// (set) Token: 0x06007E3D RID: 32317 RVA: 0x0003BFDD File Offset: 0x0003A1DD
		public unsafe string IngredientID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixOperation.NativeFieldInfoPtr_IngredientID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixOperation.NativeFieldInfoPtr_IngredientID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040055E4 RID: 21988
		private static readonly IntPtr NativeFieldInfoPtr_ProductID;

		// Token: 0x040055E5 RID: 21989
		private static readonly IntPtr NativeFieldInfoPtr_IngredientID;

		// Token: 0x040055E6 RID: 21990
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x040055E7 RID: 21991
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
