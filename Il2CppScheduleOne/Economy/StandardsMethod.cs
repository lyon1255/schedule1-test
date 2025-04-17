using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;

namespace Il2CppScheduleOne.Economy
{
	// Token: 0x02000418 RID: 1048
	public static class StandardsMethod : Object
	{
		// Token: 0x06005BA6 RID: 23462 RVA: 0x001A9054 File Offset: 0x001A7254
		// Note: this type is marked as 'beforefieldinit'.
		static StandardsMethod()
		{
			Il2CppClassPointerStore<StandardsMethod>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Economy", "StandardsMethod");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StandardsMethod>.NativeClassPtr);
			StandardsMethod.NativeMethodInfoPtr_GetName_Public_Static_String_ECustomerStandard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardsMethod>.NativeClassPtr, 100674983);
			StandardsMethod.NativeMethodInfoPtr_GetCorrespondingQuality_Public_Static_EQuality_ECustomerStandard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardsMethod>.NativeClassPtr, 100674984);
		}

		// Token: 0x06005BA7 RID: 23463 RVA: 0x001A90AC File Offset: 0x001A72AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 193365, RefRangeEnd = 193366, XrefRangeStart = 193358, XrefRangeEnd = 193365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetName(this ECustomerStandard property)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref property;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardsMethod.NativeMethodInfoPtr_GetName_Public_Static_String_ECustomerStandard_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005BA8 RID: 23464 RVA: 0x001A90E4 File Offset: 0x001A72E4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 193366, RefRangeEnd = 193374, XrefRangeStart = 193366, XrefRangeEnd = 193366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EQuality GetCorrespondingQuality(this ECustomerStandard property)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref property;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardsMethod.NativeMethodInfoPtr_GetCorrespondingQuality_Public_Static_EQuality_ECustomerStandard_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005BA9 RID: 23465 RVA: 0x0002B3A1 File Offset: 0x000295A1
		public StandardsMethod(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04003EAF RID: 16047
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_Static_String_ECustomerStandard_0;

		// Token: 0x04003EB0 RID: 16048
		private static readonly IntPtr NativeMethodInfoPtr_GetCorrespondingQuality_Public_Static_EQuality_ECustomerStandard_0;
	}
}
