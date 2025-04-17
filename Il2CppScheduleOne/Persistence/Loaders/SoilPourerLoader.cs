﻿using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x02000251 RID: 593
	public class SoilPourerLoader : GridItemLoader
	{
		// Token: 0x06002E7F RID: 11903 RVA: 0x00104C20 File Offset: 0x00102E20
		// Note: this type is marked as 'beforefieldinit'.
		static SoilPourerLoader()
		{
			Il2CppClassPointerStore<SoilPourerLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "SoilPourerLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SoilPourerLoader>.NativeClassPtr);
			SoilPourerLoader.NativeMethodInfoPtr_get_ItemType_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourerLoader>.NativeClassPtr, 100668696);
			SoilPourerLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourerLoader>.NativeClassPtr, 100668697);
			SoilPourerLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourerLoader>.NativeClassPtr, 100668698);
		}

		// Token: 0x17000F41 RID: 3905
		// (get) Token: 0x06002E80 RID: 11904 RVA: 0x00104C8C File Offset: 0x00102E8C
		public unsafe override string ItemType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130025, XrefRangeEnd = 130032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SoilPourerLoader.NativeMethodInfoPtr_get_ItemType_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002E81 RID: 11905 RVA: 0x00104CD0 File Offset: 0x00102ED0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 129554, RefRangeEnd = 129558, XrefRangeStart = 129554, XrefRangeEnd = 129558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SoilPourerLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SoilPourerLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourerLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E82 RID: 11906 RVA: 0x00104D0C File Offset: 0x00102F0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130032, XrefRangeEnd = 130059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SoilPourerLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E83 RID: 11907 RVA: 0x000189B2 File Offset: 0x00016BB2
		public SoilPourerLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001ECA RID: 7882
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemType_Public_Virtual_get_String_0;

		// Token: 0x04001ECB RID: 7883
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001ECC RID: 7884
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;
	}
}
