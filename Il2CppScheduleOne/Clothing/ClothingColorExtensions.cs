using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Clothing
{
	// Token: 0x0200049D RID: 1181
	public static class ClothingColorExtensions : Il2CppSystem.Object
	{
		// Token: 0x06006645 RID: 26181 RVA: 0x001CC554 File Offset: 0x001CA754
		// Note: this type is marked as 'beforefieldinit'.
		static ClothingColorExtensions()
		{
			Il2CppClassPointerStore<ClothingColorExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Clothing", "ClothingColorExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClothingColorExtensions>.NativeClassPtr);
			ClothingColorExtensions.NativeMethodInfoPtr_GetActualColor_Public_Static_Color_EClothingColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingColorExtensions>.NativeClassPtr, 100676234);
			ClothingColorExtensions.NativeMethodInfoPtr_GetLabelColor_Public_Static_Color_EClothingColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingColorExtensions>.NativeClassPtr, 100676235);
			ClothingColorExtensions.NativeMethodInfoPtr_GetLabel_Public_Static_String_EClothingColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingColorExtensions>.NativeClassPtr, 100676236);
			ClothingColorExtensions.NativeMethodInfoPtr_GetClothingColor_Public_Static_EClothingColor_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingColorExtensions>.NativeClassPtr, 100676237);
			ClothingColorExtensions.NativeMethodInfoPtr_ColorEquals_Public_Static_Boolean_Color_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClothingColorExtensions>.NativeClassPtr, 100676238);
		}

		// Token: 0x06006646 RID: 26182 RVA: 0x001CC5E8 File Offset: 0x001CA7E8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 206839, RefRangeEnd = 206847, XrefRangeStart = 206834, XrefRangeEnd = 206839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color GetActualColor(this EClothingColor color)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingColorExtensions.NativeMethodInfoPtr_GetActualColor_Public_Static_Color_EClothingColor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006647 RID: 26183 RVA: 0x001CC628 File Offset: 0x001CA828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206847, XrefRangeEnd = 206852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color GetLabelColor(this EClothingColor color)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingColorExtensions.NativeMethodInfoPtr_GetLabelColor_Public_Static_Color_EClothingColor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006648 RID: 26184 RVA: 0x001CC668 File Offset: 0x001CA868
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 206855, RefRangeEnd = 206857, XrefRangeStart = 206852, XrefRangeEnd = 206855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetLabel(this EClothingColor color)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingColorExtensions.NativeMethodInfoPtr_GetLabel_Public_Static_String_EClothingColor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06006649 RID: 26185 RVA: 0x001CC6A0 File Offset: 0x001CA8A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 206885, RefRangeEnd = 206888, XrefRangeStart = 206857, XrefRangeEnd = 206885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EClothingColor GetClothingColor(Color color)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingColorExtensions.NativeMethodInfoPtr_GetClothingColor_Public_Static_EClothingColor_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600664A RID: 26186 RVA: 0x001CC6E0 File Offset: 0x001CA8E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 206888, RefRangeEnd = 206889, XrefRangeStart = 206888, XrefRangeEnd = 206888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ColorEquals(Color a, Color b, float tolerance = 0.004f)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tolerance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClothingColorExtensions.NativeMethodInfoPtr_ColorEquals_Public_Static_Boolean_Color_Color_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600664B RID: 26187 RVA: 0x000305F5 File Offset: 0x0002E7F5
		public ClothingColorExtensions(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040045EA RID: 17898
		private static readonly IntPtr NativeMethodInfoPtr_GetActualColor_Public_Static_Color_EClothingColor_0;

		// Token: 0x040045EB RID: 17899
		private static readonly IntPtr NativeMethodInfoPtr_GetLabelColor_Public_Static_Color_EClothingColor_0;

		// Token: 0x040045EC RID: 17900
		private static readonly IntPtr NativeMethodInfoPtr_GetLabel_Public_Static_String_EClothingColor_0;

		// Token: 0x040045ED RID: 17901
		private static readonly IntPtr NativeMethodInfoPtr_GetClothingColor_Public_Static_EClothingColor_Color_0;

		// Token: 0x040045EE RID: 17902
		private static readonly IntPtr NativeMethodInfoPtr_ColorEquals_Public_Static_Boolean_Color_Color_Single_0;
	}
}
