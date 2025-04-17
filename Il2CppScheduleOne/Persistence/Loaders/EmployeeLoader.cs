using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x02000242 RID: 578
	public class EmployeeLoader : NPCLoader
	{
		// Token: 0x06002E2F RID: 11823 RVA: 0x001037A8 File Offset: 0x001019A8
		// Note: this type is marked as 'beforefieldinit'.
		static EmployeeLoader()
		{
			Il2CppClassPointerStore<EmployeeLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "EmployeeLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmployeeLoader>.NativeClassPtr);
			EmployeeLoader.NativeMethodInfoPtr_get_NPCType_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeLoader>.NativeClassPtr, 100668623);
			EmployeeLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeLoader>.NativeClassPtr, 100668624);
			EmployeeLoader.NativeMethodInfoPtr_LoadAndCreateEmployee_Public_Employee_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeLoader>.NativeClassPtr, 100668625);
		}

		// Token: 0x17000F32 RID: 3890
		// (get) Token: 0x06002E30 RID: 11824 RVA: 0x00103814 File Offset: 0x00101A14
		public unsafe override string NPCType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128631, XrefRangeEnd = 128638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EmployeeLoader.NativeMethodInfoPtr_get_NPCType_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002E31 RID: 11825 RVA: 0x00103858 File Offset: 0x00101A58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EmployeeLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EmployeeLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E32 RID: 11826 RVA: 0x00103894 File Offset: 0x00101A94
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 128706, RefRangeEnd = 128710, XrefRangeStart = 128638, XrefRangeEnd = 128706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Employee LoadAndCreateEmployee(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeLoader.NativeMethodInfoPtr_LoadAndCreateEmployee_Public_Employee_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Employee>(intPtr3) : null;
		}

		// Token: 0x06002E33 RID: 11827 RVA: 0x0001892B File Offset: 0x00016B2B
		public EmployeeLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001E98 RID: 7832
		private static readonly IntPtr NativeMethodInfoPtr_get_NPCType_Public_Virtual_get_String_0;

		// Token: 0x04001E99 RID: 7833
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001E9A RID: 7834
		private static readonly IntPtr NativeMethodInfoPtr_LoadAndCreateEmployee_Public_Employee_String_0;
	}
}
