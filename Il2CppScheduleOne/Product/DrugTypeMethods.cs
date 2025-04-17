using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x0200059B RID: 1435
	public static class DrugTypeMethods : Il2CppSystem.Object
	{
		// Token: 0x06007DE2 RID: 32226 RVA: 0x0021B290 File Offset: 0x00219490
		// Note: this type is marked as 'beforefieldinit'.
		static DrugTypeMethods()
		{
			Il2CppClassPointerStore<DrugTypeMethods>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "DrugTypeMethods");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrugTypeMethods>.NativeClassPtr);
			DrugTypeMethods.NativeMethodInfoPtr_GetName_Public_Static_String_EDrugType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrugTypeMethods>.NativeClassPtr, 100679038);
			DrugTypeMethods.NativeMethodInfoPtr_GetColor_Public_Static_Color_EDrugType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrugTypeMethods>.NativeClassPtr, 100679039);
		}

		// Token: 0x06007DE3 RID: 32227 RVA: 0x0021B2E8 File Offset: 0x002194E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238363, XrefRangeEnd = 238364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetName(this EDrugType property)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref property;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrugTypeMethods.NativeMethodInfoPtr_GetName_Public_Static_String_EDrugType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06007DE4 RID: 32228 RVA: 0x0021B320 File Offset: 0x00219520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238364, XrefRangeEnd = 238365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color GetColor(this EDrugType property)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref property;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrugTypeMethods.NativeMethodInfoPtr_GetColor_Public_Static_Color_EDrugType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007DE5 RID: 32229 RVA: 0x0003BD57 File Offset: 0x00039F57
		public DrugTypeMethods(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040055A0 RID: 21920
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_Static_String_EDrugType_0;

		// Token: 0x040055A1 RID: 21921
		private static readonly IntPtr NativeMethodInfoPtr_GetColor_Public_Static_Color_EDrugType_0;
	}
}
