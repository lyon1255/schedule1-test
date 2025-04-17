using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x02000250 RID: 592
	public class ProceduralGridItemLoader : BuildableItemLoader
	{
		// Token: 0x06002E79 RID: 11897 RVA: 0x00104A80 File Offset: 0x00102C80
		// Note: this type is marked as 'beforefieldinit'.
		static ProceduralGridItemLoader()
		{
			Il2CppClassPointerStore<ProceduralGridItemLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "ProceduralGridItemLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProceduralGridItemLoader>.NativeClassPtr);
			ProceduralGridItemLoader.NativeMethodInfoPtr_get_ItemType_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItemLoader>.NativeClassPtr, 100668692);
			ProceduralGridItemLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItemLoader>.NativeClassPtr, 100668693);
			ProceduralGridItemLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItemLoader>.NativeClassPtr, 100668694);
			ProceduralGridItemLoader.NativeMethodInfoPtr_LoadAndCreate_Protected_ProceduralGridItem_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProceduralGridItemLoader>.NativeClassPtr, 100668695);
		}

		// Token: 0x17000F40 RID: 3904
		// (get) Token: 0x06002E7A RID: 11898 RVA: 0x00104B00 File Offset: 0x00102D00
		public unsafe override string ItemType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129958, XrefRangeEnd = 129965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProceduralGridItemLoader.NativeMethodInfoPtr_get_ItemType_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002E7B RID: 11899 RVA: 0x00104B44 File Offset: 0x00102D44
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 129034, RefRangeEnd = 129043, XrefRangeStart = 129034, XrefRangeEnd = 129043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProceduralGridItemLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProceduralGridItemLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItemLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E7C RID: 11900 RVA: 0x00104B80 File Offset: 0x00102D80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 129965, XrefRangeEnd = 129966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProceduralGridItemLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E7D RID: 11901 RVA: 0x00104BD0 File Offset: 0x00102DD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130024, RefRangeEnd = 130025, XrefRangeStart = 129966, XrefRangeEnd = 130024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProceduralGridItem LoadAndCreate(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProceduralGridItemLoader.NativeMethodInfoPtr_LoadAndCreate_Protected_ProceduralGridItem_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProceduralGridItem>(intPtr3) : null;
		}

		// Token: 0x06002E7E RID: 11902 RVA: 0x000189A9 File Offset: 0x00016BA9
		public ProceduralGridItemLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001EC6 RID: 7878
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemType_Public_Virtual_get_String_0;

		// Token: 0x04001EC7 RID: 7879
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001EC8 RID: 7880
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;

		// Token: 0x04001EC9 RID: 7881
		private static readonly IntPtr NativeMethodInfoPtr_LoadAndCreate_Protected_ProceduralGridItem_String_0;
	}
}
