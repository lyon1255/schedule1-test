using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x02000224 RID: 548
	public class BusinessLoader : PropertyLoader
	{
		// Token: 0x06002DB0 RID: 11696 RVA: 0x00101A10 File Offset: 0x000FFC10
		// Note: this type is marked as 'beforefieldinit'.
		static BusinessLoader()
		{
			Il2CppClassPointerStore<BusinessLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "BusinessLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BusinessLoader>.NativeClassPtr);
			BusinessLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BusinessLoader>.NativeClassPtr, 100668528);
			BusinessLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BusinessLoader>.NativeClassPtr, 100668529);
		}

		// Token: 0x06002DB1 RID: 11697 RVA: 0x00101A68 File Offset: 0x000FFC68
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BusinessLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BusinessLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BusinessLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DB2 RID: 11698 RVA: 0x00101AA4 File Offset: 0x000FFCA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127184, XrefRangeEnd = 127208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BusinessLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DB3 RID: 11699 RVA: 0x0001881D File Offset: 0x00016A1D
		public BusinessLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001E55 RID: 7765
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001E56 RID: 7766
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;
	}
}
