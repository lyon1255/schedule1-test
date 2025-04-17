using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x02000390 RID: 912
	public static class ConfigurableType : Object
	{
		// Token: 0x060047B8 RID: 18360 RVA: 0x00022B0D File Offset: 0x00020D0D
		// Note: this type is marked as 'beforefieldinit'.
		static ConfigurableType()
		{
			Il2CppClassPointerStore<ConfigurableType>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "ConfigurableType");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigurableType>.NativeClassPtr);
			ConfigurableType.NativeMethodInfoPtr_GetTypeName_Public_Static_String_EConfigurableType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigurableType>.NativeClassPtr, 100672166);
		}

		// Token: 0x060047B9 RID: 18361 RVA: 0x0015F824 File Offset: 0x0015DA24
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 161291, RefRangeEnd = 161293, XrefRangeStart = 161274, XrefRangeEnd = 161291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetTypeName(EConfigurableType type)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigurableType.NativeMethodInfoPtr_GetTypeName_Public_Static_String_EConfigurableType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060047BA RID: 18362 RVA: 0x00022B46 File Offset: 0x00020D46
		public ConfigurableType(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04003058 RID: 12376
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeName_Public_Static_String_EConfigurableType_0;
	}
}
