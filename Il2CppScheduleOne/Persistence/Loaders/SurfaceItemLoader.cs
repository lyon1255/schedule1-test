using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x02000254 RID: 596
	public class SurfaceItemLoader : BuildableItemLoader
	{
		// Token: 0x06002E8E RID: 11918 RVA: 0x00104FD4 File Offset: 0x001031D4
		// Note: this type is marked as 'beforefieldinit'.
		static SurfaceItemLoader()
		{
			Il2CppClassPointerStore<SurfaceItemLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "SurfaceItemLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SurfaceItemLoader>.NativeClassPtr);
			SurfaceItemLoader.NativeMethodInfoPtr_get_ItemType_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItemLoader>.NativeClassPtr, 100668705);
			SurfaceItemLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItemLoader>.NativeClassPtr, 100668706);
			SurfaceItemLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItemLoader>.NativeClassPtr, 100668707);
			SurfaceItemLoader.NativeMethodInfoPtr_LoadAndCreate_Protected_SurfaceItem_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SurfaceItemLoader>.NativeClassPtr, 100668708);
		}

		// Token: 0x17000F44 RID: 3908
		// (get) Token: 0x06002E8F RID: 11919 RVA: 0x00105054 File Offset: 0x00103254
		public unsafe override string ItemType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130131, XrefRangeEnd = 130138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SurfaceItemLoader.NativeMethodInfoPtr_get_ItemType_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002E90 RID: 11920 RVA: 0x00105098 File Offset: 0x00103298
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 129034, RefRangeEnd = 129043, XrefRangeStart = 129034, XrefRangeEnd = 129043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SurfaceItemLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SurfaceItemLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceItemLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E91 RID: 11921 RVA: 0x001050D4 File Offset: 0x001032D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130138, XrefRangeEnd = 130139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SurfaceItemLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E92 RID: 11922 RVA: 0x00105124 File Offset: 0x00103324
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 130180, RefRangeEnd = 130184, XrefRangeStart = 130139, XrefRangeEnd = 130180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SurfaceItem LoadAndCreate(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SurfaceItemLoader.NativeMethodInfoPtr_LoadAndCreate_Protected_SurfaceItem_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SurfaceItem>(intPtr3) : null;
		}

		// Token: 0x06002E93 RID: 11923 RVA: 0x000189CD File Offset: 0x00016BCD
		public SurfaceItemLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001ED3 RID: 7891
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemType_Public_Virtual_get_String_0;

		// Token: 0x04001ED4 RID: 7892
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001ED5 RID: 7893
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;

		// Token: 0x04001ED6 RID: 7894
		private static readonly IntPtr NativeMethodInfoPtr_LoadAndCreate_Protected_SurfaceItem_String_0;
	}
}
