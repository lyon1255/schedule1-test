using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Clothing;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000263 RID: 611
	[Serializable]
	public class ClothingData : ItemData
	{
		// Token: 0x06002F1F RID: 12063 RVA: 0x00106C28 File Offset: 0x00104E28
		// Note: this type is marked as 'beforefieldinit'.
		static ClothingData()
		{
			Il2CppClassPointerStore<ClothingData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "ClothingData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothingData>.NativeClassPtr);
			ClothingData.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClothingData>.NativeClassPtr, "Color");
			ClothingData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_EClothingColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingData>.NativeClassPtr, 100668758);
		}

		// Token: 0x06002F20 RID: 12064 RVA: 0x00106C80 File Offset: 0x00104E80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 130592, RefRangeEnd = 130594, XrefRangeStart = 130590, XrefRangeEnd = 130592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClothingData(string iD, int quantity, EClothingColor color) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClothingData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(iD);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_EClothingColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F21 RID: 12065 RVA: 0x00018E77 File Offset: 0x00017077
		public ClothingData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F6D RID: 3949
		// (get) Token: 0x06002F22 RID: 12066 RVA: 0x00106CE8 File Offset: 0x00104EE8
		// (set) Token: 0x06002F23 RID: 12067 RVA: 0x00018E80 File Offset: 0x00017080
		public unsafe EClothingColor Color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingData.NativeFieldInfoPtr_Color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClothingData.NativeFieldInfoPtr_Color)) = value;
			}
		}

		// Token: 0x04001F21 RID: 7969
		private static readonly IntPtr NativeFieldInfoPtr_Color;

		// Token: 0x04001F22 RID: 7970
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_EClothingColor_0;
	}
}
