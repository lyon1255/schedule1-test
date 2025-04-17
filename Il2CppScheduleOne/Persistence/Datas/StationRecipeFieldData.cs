using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000285 RID: 645
	[Serializable]
	public class StationRecipeFieldData : Object
	{
		// Token: 0x06002FEA RID: 12266 RVA: 0x00108DD0 File Offset: 0x00106FD0
		// Note: this type is marked as 'beforefieldinit'.
		static StationRecipeFieldData()
		{
			Il2CppClassPointerStore<StationRecipeFieldData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "StationRecipeFieldData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StationRecipeFieldData>.NativeClassPtr);
			StationRecipeFieldData.NativeFieldInfoPtr_RecipeID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StationRecipeFieldData>.NativeClassPtr, "RecipeID");
			StationRecipeFieldData.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StationRecipeFieldData>.NativeClassPtr, 100668793);
		}

		// Token: 0x06002FEB RID: 12267 RVA: 0x00108E28 File Offset: 0x00107028
		[CallerCount(177)]
		[CachedScanResults(RefRangeStart = 17915, RefRangeEnd = 18092, XrefRangeStart = 17915, XrefRangeEnd = 18092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StationRecipeFieldData(string recipeID) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StationRecipeFieldData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(recipeID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StationRecipeFieldData.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FEC RID: 12268 RVA: 0x00019667 File Offset: 0x00017867
		public StationRecipeFieldData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F9F RID: 3999
		// (get) Token: 0x06002FED RID: 12269 RVA: 0x00108E74 File Offset: 0x00107074
		// (set) Token: 0x06002FEE RID: 12270 RVA: 0x00019670 File Offset: 0x00017870
		public unsafe string RecipeID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeFieldData.NativeFieldInfoPtr_RecipeID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StationRecipeFieldData.NativeFieldInfoPtr_RecipeID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001F76 RID: 8054
		private static readonly IntPtr NativeFieldInfoPtr_RecipeID;

		// Token: 0x04001F77 RID: 8055
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
