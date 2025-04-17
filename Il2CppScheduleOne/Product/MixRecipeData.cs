using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x020005A2 RID: 1442
	[Serializable]
	public class MixRecipeData : Object
	{
		// Token: 0x06007E13 RID: 32275 RVA: 0x0021BE44 File Offset: 0x0021A044
		// Note: this type is marked as 'beforefieldinit'.
		static MixRecipeData()
		{
			Il2CppClassPointerStore<MixRecipeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "MixRecipeData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MixRecipeData>.NativeClassPtr);
			MixRecipeData.NativeFieldInfoPtr_Product = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixRecipeData>.NativeClassPtr, "Product");
			MixRecipeData.NativeFieldInfoPtr_Mixer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixRecipeData>.NativeClassPtr, "Mixer");
			MixRecipeData.NativeFieldInfoPtr_Output = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixRecipeData>.NativeClassPtr, "Output");
			MixRecipeData.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixRecipeData>.NativeClassPtr, 100679066);
		}

		// Token: 0x06007E14 RID: 32276 RVA: 0x0021BEC4 File Offset: 0x0021A0C4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 17408, RefRangeEnd = 17415, XrefRangeStart = 17408, XrefRangeEnd = 17415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MixRecipeData(string product, string mixer, string output) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MixRecipeData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(product);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(mixer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(output);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixRecipeData.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E15 RID: 32277 RVA: 0x0003BE37 File Offset: 0x0003A037
		public MixRecipeData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002620 RID: 9760
		// (get) Token: 0x06007E16 RID: 32278 RVA: 0x0021BF34 File Offset: 0x0021A134
		// (set) Token: 0x06007E17 RID: 32279 RVA: 0x0003BE40 File Offset: 0x0003A040
		public unsafe string Product
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixRecipeData.NativeFieldInfoPtr_Product);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixRecipeData.NativeFieldInfoPtr_Product), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002621 RID: 9761
		// (get) Token: 0x06007E18 RID: 32280 RVA: 0x0021BF5C File Offset: 0x0021A15C
		// (set) Token: 0x06007E19 RID: 32281 RVA: 0x0003BE5F File Offset: 0x0003A05F
		public unsafe string Mixer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixRecipeData.NativeFieldInfoPtr_Mixer);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixRecipeData.NativeFieldInfoPtr_Mixer), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002622 RID: 9762
		// (get) Token: 0x06007E1A RID: 32282 RVA: 0x0021BF84 File Offset: 0x0021A184
		// (set) Token: 0x06007E1B RID: 32283 RVA: 0x0003BE7E File Offset: 0x0003A07E
		public unsafe string Output
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixRecipeData.NativeFieldInfoPtr_Output);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixRecipeData.NativeFieldInfoPtr_Output), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040055D1 RID: 21969
		private static readonly IntPtr NativeFieldInfoPtr_Product;

		// Token: 0x040055D2 RID: 21970
		private static readonly IntPtr NativeFieldInfoPtr_Mixer;

		// Token: 0x040055D3 RID: 21971
		private static readonly IntPtr NativeFieldInfoPtr_Output;

		// Token: 0x040055D4 RID: 21972
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0;
	}
}
