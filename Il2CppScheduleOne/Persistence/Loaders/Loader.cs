using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x0200022A RID: 554
	public class Loader : Object
	{
		// Token: 0x06002DC9 RID: 11721 RVA: 0x00101FC0 File Offset: 0x001001C0
		// Note: this type is marked as 'beforefieldinit'.
		static Loader()
		{
			Il2CppClassPointerStore<Loader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "Loader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Loader>.NativeClassPtr);
			Loader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader>.NativeClassPtr, 100668541);
			Loader.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader>.NativeClassPtr, 100668542);
			Loader.NativeMethodInfoPtr_TryLoadFile_Public_Boolean_String_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader>.NativeClassPtr, 100668543);
			Loader.NativeMethodInfoPtr_TryLoadFile_Public_Boolean_String_byref_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader>.NativeClassPtr, 100668544);
			Loader.NativeMethodInfoPtr_GetDirectories_Protected_List_1_DirectoryInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Loader>.NativeClassPtr, 100668545);
		}

		// Token: 0x06002DCA RID: 11722 RVA: 0x00102054 File Offset: 0x00100254
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Loader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Loader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DCB RID: 11723 RVA: 0x00102090 File Offset: 0x00100290
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Loader.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DCC RID: 11724 RVA: 0x001020E0 File Offset: 0x001002E0
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 127345, RefRangeEnd = 127356, XrefRangeStart = 127340, XrefRangeEnd = 127345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryLoadFile(string parentPath, string fileName, out string contents)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentPath);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fileName);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Loader.NativeMethodInfoPtr_TryLoadFile_Public_Boolean_String_String_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			contents = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06002DCD RID: 11725 RVA: 0x0010215C File Offset: 0x0010035C
		[CallerCount(55)]
		[CachedScanResults(RefRangeStart = 127365, RefRangeEnd = 127420, XrefRangeStart = 127356, XrefRangeEnd = 127365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryLoadFile(string path, out string contents, bool autoAddExtension = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoAddExtension;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Loader.NativeMethodInfoPtr_TryLoadFile_Public_Boolean_String_byref_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			contents = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06002DCE RID: 11726 RVA: 0x001021D4 File Offset: 0x001003D4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 127438, RefRangeEnd = 127446, XrefRangeStart = 127420, XrefRangeEnd = 127438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<DirectoryInfo> GetDirectories(string parentPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Loader.NativeMethodInfoPtr_GetDirectories_Protected_List_1_DirectoryInfo_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<DirectoryInfo>>(intPtr3) : null;
		}

		// Token: 0x06002DCF RID: 11727 RVA: 0x00018853 File Offset: 0x00016A53
		public Loader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001E62 RID: 7778
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001E63 RID: 7779
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_New_Void_String_0;

		// Token: 0x04001E64 RID: 7780
		private static readonly IntPtr NativeMethodInfoPtr_TryLoadFile_Public_Boolean_String_String_byref_String_0;

		// Token: 0x04001E65 RID: 7781
		private static readonly IntPtr NativeMethodInfoPtr_TryLoadFile_Public_Boolean_String_byref_String_Boolean_0;

		// Token: 0x04001E66 RID: 7782
		private static readonly IntPtr NativeMethodInfoPtr_GetDirectories_Protected_List_1_DirectoryInfo_String_0;
	}
}
