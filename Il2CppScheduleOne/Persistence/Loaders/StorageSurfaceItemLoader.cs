using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x02000253 RID: 595
	public class StorageSurfaceItemLoader : SurfaceItemLoader
	{
		// Token: 0x06002E89 RID: 11913 RVA: 0x00104E98 File Offset: 0x00103098
		// Note: this type is marked as 'beforefieldinit'.
		static StorageSurfaceItemLoader()
		{
			Il2CppClassPointerStore<StorageSurfaceItemLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "StorageSurfaceItemLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StorageSurfaceItemLoader>.NativeClassPtr);
			StorageSurfaceItemLoader.NativeMethodInfoPtr_get_ItemType_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageSurfaceItemLoader>.NativeClassPtr, 100668702);
			StorageSurfaceItemLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageSurfaceItemLoader>.NativeClassPtr, 100668703);
			StorageSurfaceItemLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageSurfaceItemLoader>.NativeClassPtr, 100668704);
		}

		// Token: 0x17000F43 RID: 3907
		// (get) Token: 0x06002E8A RID: 11914 RVA: 0x00104F04 File Offset: 0x00103104
		public unsafe override string ItemType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130095, XrefRangeEnd = 130102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorageSurfaceItemLoader.NativeMethodInfoPtr_get_ItemType_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002E8B RID: 11915 RVA: 0x00104F48 File Offset: 0x00103148
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 129034, RefRangeEnd = 129043, XrefRangeStart = 129034, XrefRangeEnd = 129043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StorageSurfaceItemLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorageSurfaceItemLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageSurfaceItemLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E8C RID: 11916 RVA: 0x00104F84 File Offset: 0x00103184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130102, XrefRangeEnd = 130131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorageSurfaceItemLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E8D RID: 11917 RVA: 0x000189C4 File Offset: 0x00016BC4
		public StorageSurfaceItemLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001ED0 RID: 7888
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemType_Public_Virtual_get_String_0;

		// Token: 0x04001ED1 RID: 7889
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001ED2 RID: 7890
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;
	}
}
