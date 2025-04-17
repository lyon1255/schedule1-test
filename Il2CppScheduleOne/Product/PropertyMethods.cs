using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x0200059E RID: 1438
	public static class PropertyMethods : Il2CppSystem.Object
	{
		// Token: 0x06007DEB RID: 32235 RVA: 0x0021B41C File Offset: 0x0021961C
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyMethods()
		{
			Il2CppClassPointerStore<PropertyMethods>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "PropertyMethods");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyMethods>.NativeClassPtr);
			PropertyMethods.NativeMethodInfoPtr_GetName_Public_Static_String_EProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyMethods>.NativeClassPtr, 100679041);
			PropertyMethods.NativeMethodInfoPtr_GetDescription_Public_Static_String_EProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyMethods>.NativeClassPtr, 100679042);
			PropertyMethods.NativeMethodInfoPtr_GetColor_Public_Static_Color_EProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyMethods>.NativeClassPtr, 100679043);
		}

		// Token: 0x06007DEC RID: 32236 RVA: 0x0021B488 File Offset: 0x00219688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238365, XrefRangeEnd = 238366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetName(this EProperty property)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref property;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyMethods.NativeMethodInfoPtr_GetName_Public_Static_String_EProperty_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06007DED RID: 32237 RVA: 0x0021B4C0 File Offset: 0x002196C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238366, XrefRangeEnd = 238367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetDescription(this EProperty property)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref property;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyMethods.NativeMethodInfoPtr_GetDescription_Public_Static_String_EProperty_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06007DEE RID: 32238 RVA: 0x0021B4F8 File Offset: 0x002196F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238367, XrefRangeEnd = 238368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color GetColor(this EProperty property)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref property;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyMethods.NativeMethodInfoPtr_GetColor_Public_Static_Color_EProperty_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007DEF RID: 32239 RVA: 0x0003BD84 File Offset: 0x00039F84
		public PropertyMethods(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040055B6 RID: 21942
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_Static_String_EProperty_0;

		// Token: 0x040055B7 RID: 21943
		private static readonly IntPtr NativeMethodInfoPtr_GetDescription_Public_Static_String_EProperty_0;

		// Token: 0x040055B8 RID: 21944
		private static readonly IntPtr NativeMethodInfoPtr_GetColor_Public_Static_Color_EProperty_0;
	}
}
