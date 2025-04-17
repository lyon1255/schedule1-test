using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x0200024B RID: 587
	public class LabelledSurfaceItemLoader : SurfaceItemLoader
	{
		// Token: 0x06002E60 RID: 11872 RVA: 0x00104454 File Offset: 0x00102654
		// Note: this type is marked as 'beforefieldinit'.
		static LabelledSurfaceItemLoader()
		{
			Il2CppClassPointerStore<LabelledSurfaceItemLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "LabelledSurfaceItemLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LabelledSurfaceItemLoader>.NativeClassPtr);
			LabelledSurfaceItemLoader.NativeMethodInfoPtr_get_ItemType_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelledSurfaceItemLoader>.NativeClassPtr, 100668669);
			LabelledSurfaceItemLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelledSurfaceItemLoader>.NativeClassPtr, 100668670);
			LabelledSurfaceItemLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabelledSurfaceItemLoader>.NativeClassPtr, 100668671);
		}

		// Token: 0x17000F3B RID: 3899
		// (get) Token: 0x06002E61 RID: 11873 RVA: 0x001044C0 File Offset: 0x001026C0
		public unsafe override string ItemType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129546, XrefRangeEnd = 129553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LabelledSurfaceItemLoader.NativeMethodInfoPtr_get_ItemType_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002E62 RID: 11874 RVA: 0x00104504 File Offset: 0x00102704
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 129554, RefRangeEnd = 129558, XrefRangeStart = 129553, XrefRangeEnd = 129554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LabelledSurfaceItemLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LabelledSurfaceItemLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabelledSurfaceItemLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E63 RID: 11875 RVA: 0x00104540 File Offset: 0x00102740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129558, XrefRangeEnd = 129585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LabelledSurfaceItemLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E64 RID: 11876 RVA: 0x0001897C File Offset: 0x00016B7C
		public LabelledSurfaceItemLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001EB7 RID: 7863
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemType_Public_Virtual_get_String_0;

		// Token: 0x04001EB8 RID: 7864
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001EB9 RID: 7865
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;
	}
}
