using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x02000257 RID: 599
	public class TrashContainerLoader : GridItemLoader
	{
		// Token: 0x06002E9E RID: 11934 RVA: 0x001053EC File Offset: 0x001035EC
		// Note: this type is marked as 'beforefieldinit'.
		static TrashContainerLoader()
		{
			Il2CppClassPointerStore<TrashContainerLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "TrashContainerLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashContainerLoader>.NativeClassPtr);
			TrashContainerLoader.NativeMethodInfoPtr_get_ItemType_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerLoader>.NativeClassPtr, 100668715);
			TrashContainerLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerLoader>.NativeClassPtr, 100668716);
			TrashContainerLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerLoader>.NativeClassPtr, 100668717);
		}

		// Token: 0x17000F47 RID: 3911
		// (get) Token: 0x06002E9F RID: 11935 RVA: 0x00105458 File Offset: 0x00103658
		public unsafe override string ItemType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130252, XrefRangeEnd = 130259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashContainerLoader.NativeMethodInfoPtr_get_ItemType_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002EA0 RID: 11936 RVA: 0x0010549C File Offset: 0x0010369C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 129554, RefRangeEnd = 129558, XrefRangeStart = 129554, XrefRangeEnd = 129558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashContainerLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashContainerLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EA1 RID: 11937 RVA: 0x001054D8 File Offset: 0x001036D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130259, XrefRangeEnd = 130286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashContainerLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EA2 RID: 11938 RVA: 0x000189E8 File Offset: 0x00016BE8
		public TrashContainerLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001EDD RID: 7901
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemType_Public_Virtual_get_String_0;

		// Token: 0x04001EDE RID: 7902
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001EDF RID: 7903
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;
	}
}
