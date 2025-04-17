using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x02000252 RID: 594
	public class StorageRackLoader : GridItemLoader
	{
		// Token: 0x06002E84 RID: 11908 RVA: 0x00104D5C File Offset: 0x00102F5C
		// Note: this type is marked as 'beforefieldinit'.
		static StorageRackLoader()
		{
			Il2CppClassPointerStore<StorageRackLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "StorageRackLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StorageRackLoader>.NativeClassPtr);
			StorageRackLoader.NativeMethodInfoPtr_get_ItemType_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageRackLoader>.NativeClassPtr, 100668699);
			StorageRackLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageRackLoader>.NativeClassPtr, 100668700);
			StorageRackLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageRackLoader>.NativeClassPtr, 100668701);
		}

		// Token: 0x17000F42 RID: 3906
		// (get) Token: 0x06002E85 RID: 11909 RVA: 0x00104DC8 File Offset: 0x00102FC8
		public unsafe override string ItemType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130059, XrefRangeEnd = 130066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorageRackLoader.NativeMethodInfoPtr_get_ItemType_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002E86 RID: 11910 RVA: 0x00104E0C File Offset: 0x0010300C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 129554, RefRangeEnd = 129558, XrefRangeStart = 129554, XrefRangeEnd = 129558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StorageRackLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorageRackLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageRackLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E87 RID: 11911 RVA: 0x00104E48 File Offset: 0x00103048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130066, XrefRangeEnd = 130095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorageRackLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E88 RID: 11912 RVA: 0x000189BB File Offset: 0x00016BBB
		public StorageRackLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001ECD RID: 7885
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemType_Public_Virtual_get_String_0;

		// Token: 0x04001ECE RID: 7886
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001ECF RID: 7887
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;
	}
}
