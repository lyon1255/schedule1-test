using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x0200024A RID: 586
	public class GridItemLoader : BuildableItemLoader
	{
		// Token: 0x06002E5A RID: 11866 RVA: 0x001042B4 File Offset: 0x001024B4
		// Note: this type is marked as 'beforefieldinit'.
		static GridItemLoader()
		{
			Il2CppClassPointerStore<GridItemLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "GridItemLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GridItemLoader>.NativeClassPtr);
			GridItemLoader.NativeMethodInfoPtr_get_ItemType_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItemLoader>.NativeClassPtr, 100668665);
			GridItemLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItemLoader>.NativeClassPtr, 100668666);
			GridItemLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItemLoader>.NativeClassPtr, 100668667);
			GridItemLoader.NativeMethodInfoPtr_LoadAndCreate_Protected_GridItem_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItemLoader>.NativeClassPtr, 100668668);
		}

		// Token: 0x17000F3A RID: 3898
		// (get) Token: 0x06002E5B RID: 11867 RVA: 0x00104334 File Offset: 0x00102534
		public unsafe override string ItemType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129487, XrefRangeEnd = 129494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GridItemLoader.NativeMethodInfoPtr_get_ItemType_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002E5C RID: 11868 RVA: 0x00104378 File Offset: 0x00102578
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 129034, RefRangeEnd = 129043, XrefRangeStart = 129034, XrefRangeEnd = 129043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GridItemLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GridItemLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItemLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E5D RID: 11869 RVA: 0x001043B4 File Offset: 0x001025B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129494, XrefRangeEnd = 129495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GridItemLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E5E RID: 11870 RVA: 0x00104404 File Offset: 0x00102604
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 129533, RefRangeEnd = 129546, XrefRangeStart = 129495, XrefRangeEnd = 129533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GridItem LoadAndCreate(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItemLoader.NativeMethodInfoPtr_LoadAndCreate_Protected_GridItem_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GridItem>(intPtr3) : null;
		}

		// Token: 0x06002E5F RID: 11871 RVA: 0x00018973 File Offset: 0x00016B73
		public GridItemLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001EB3 RID: 7859
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemType_Public_Virtual_get_String_0;

		// Token: 0x04001EB4 RID: 7860
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001EB5 RID: 7861
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;

		// Token: 0x04001EB6 RID: 7862
		private static readonly IntPtr NativeMethodInfoPtr_LoadAndCreate_Protected_GridItem_String_0;
	}
}
