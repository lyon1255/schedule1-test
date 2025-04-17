using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;

namespace Il2CppScheduleOne
{
	// Token: 0x02000169 RID: 361
	public class IGUIDRegisterable : Il2CppObjectBase
	{
		// Token: 0x06001D24 RID: 7460 RVA: 0x000CAEFC File Offset: 0x000C90FC
		// Note: this type is marked as 'beforefieldinit'.
		static IGUIDRegisterable()
		{
			Il2CppClassPointerStore<IGUIDRegisterable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne", "IGUIDRegisterable");
			IGUIDRegisterable.NativeMethodInfoPtr_get_GUID_Public_Abstract_Virtual_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGUIDRegisterable>.NativeClassPtr, 100666593);
			IGUIDRegisterable.NativeMethodInfoPtr_SetGUID_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGUIDRegisterable>.NativeClassPtr, 100666594);
			IGUIDRegisterable.NativeMethodInfoPtr_SetGUID_Public_Abstract_Virtual_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGUIDRegisterable>.NativeClassPtr, 100666595);
		}

		// Token: 0x17000A1F RID: 2591
		// (get) Token: 0x06001D25 RID: 7461 RVA: 0x000CAF60 File Offset: 0x000C9160
		public unsafe virtual Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGUIDRegisterable.NativeMethodInfoPtr_get_GUID_Public_Abstract_Virtual_New_get_Guid_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D26 RID: 7462 RVA: 0x000CAFA8 File Offset: 0x000C91A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 104763, XrefRangeEnd = 104775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetGUID(string guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGUIDRegisterable.NativeMethodInfoPtr_SetGUID_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D27 RID: 7463 RVA: 0x000CAFF8 File Offset: 0x000C91F8
		[CallerCount(0)]
		public unsafe virtual void SetGUID(Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IGUIDRegisterable.NativeMethodInfoPtr_SetGUID_Public_Abstract_Virtual_New_Void_Guid_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D28 RID: 7464 RVA: 0x00010920 File Offset: 0x0000EB20
		public IGUIDRegisterable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400134E RID: 4942
		private static readonly IntPtr NativeMethodInfoPtr_get_GUID_Public_Abstract_Virtual_New_get_Guid_0;

		// Token: 0x0400134F RID: 4943
		private static readonly IntPtr NativeMethodInfoPtr_SetGUID_Public_Virtual_New_Void_String_0;

		// Token: 0x04001350 RID: 4944
		private static readonly IntPtr NativeMethodInfoPtr_SetGUID_Public_Abstract_Virtual_New_Void_Guid_0;
	}
}
