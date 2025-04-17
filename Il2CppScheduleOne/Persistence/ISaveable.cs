using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Persistence
{
	// Token: 0x02000219 RID: 537
	public class ISaveable : Il2CppObjectBase
	{
		// Token: 0x06002C94 RID: 11412 RVA: 0x000FDD68 File Offset: 0x000FBF68
		// Note: this type is marked as 'beforefieldinit'.
		static ISaveable()
		{
			Il2CppClassPointerStore<ISaveable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence", "ISaveable");
			ISaveable.NativeMethodInfoPtr_get_SaveFolderName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISaveable>.NativeClassPtr, 100668320);
			ISaveable.NativeMethodInfoPtr_get_SaveFileName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISaveable>.NativeClassPtr, 100668321);
			ISaveable.NativeMethodInfoPtr_get_Loader_Public_Abstract_Virtual_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISaveable>.NativeClassPtr, 100668322);
			ISaveable.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISaveable>.NativeClassPtr, 100668323);
			ISaveable.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Abstract_Virtual_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISaveable>.NativeClassPtr, 100668324);
			ISaveable.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Abstract_Virtual_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISaveable>.NativeClassPtr, 100668325);
			ISaveable.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Abstract_Virtual_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISaveable>.NativeClassPtr, 100668326);
			ISaveable.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Abstract_Virtual_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISaveable>.NativeClassPtr, 100668327);
			ISaveable.NativeMethodInfoPtr_get_HasChanged_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISaveable>.NativeClassPtr, 100668328);
			ISaveable.NativeMethodInfoPtr_set_HasChanged_Public_Abstract_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISaveable>.NativeClassPtr, 100668329);
			ISaveable.NativeMethodInfoPtr_InitializeSaveable_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISaveable>.NativeClassPtr, 100668330);
			ISaveable.NativeMethodInfoPtr_GetSaveString_Public_Abstract_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISaveable>.NativeClassPtr, 100668331);
			ISaveable.NativeMethodInfoPtr_Save_Public_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISaveable>.NativeClassPtr, 100668332);
			ISaveable.NativeMethodInfoPtr_WriteBaseData_Public_Virtual_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISaveable>.NativeClassPtr, 100668333);
			ISaveable.NativeMethodInfoPtr_GetLocalPath_Public_Virtual_New_String_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISaveable>.NativeClassPtr, 100668334);
			ISaveable.NativeMethodInfoPtr_CompleteSave_Public_Virtual_New_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISaveable>.NativeClassPtr, 100668335);
			ISaveable.NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISaveable>.NativeClassPtr, 100668336);
			ISaveable.NativeMethodInfoPtr_DeleteUnapprovedFiles_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISaveable>.NativeClassPtr, 100668337);
			ISaveable.NativeMethodInfoPtr_GetContainerFolder_Public_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISaveable>.NativeClassPtr, 100668338);
			ISaveable.NativeMethodInfoPtr_WriteSubfile_Public_Virtual_New_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISaveable>.NativeClassPtr, 100668339);
			ISaveable.NativeMethodInfoPtr_WriteFolder_Public_Virtual_New_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISaveable>.NativeClassPtr, 100668340);
			ISaveable.NativeMethodInfoPtr_TryLoadFile_Public_Virtual_New_Boolean_String_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISaveable>.NativeClassPtr, 100668341);
			ISaveable.NativeMethodInfoPtr_TryLoadFile_Public_Virtual_New_Boolean_String_byref_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISaveable>.NativeClassPtr, 100668342);
		}

		// Token: 0x17000ED2 RID: 3794
		// (get) Token: 0x06002C95 RID: 11413 RVA: 0x000FDF5C File Offset: 0x000FC15C
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISaveable.NativeMethodInfoPtr_get_SaveFolderName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000ED3 RID: 3795
		// (get) Token: 0x06002C96 RID: 11414 RVA: 0x000FDFA0 File Offset: 0x000FC1A0
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISaveable.NativeMethodInfoPtr_get_SaveFileName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000ED4 RID: 3796
		// (get) Token: 0x06002C97 RID: 11415 RVA: 0x000FDFE4 File Offset: 0x000FC1E4
		public unsafe virtual Loader Loader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISaveable.NativeMethodInfoPtr_get_Loader_Public_Abstract_Virtual_New_get_Loader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr3) : null;
			}
		}

		// Token: 0x17000ED5 RID: 3797
		// (get) Token: 0x06002C98 RID: 11416 RVA: 0x000FE030 File Offset: 0x000FC230
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISaveable.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000ED6 RID: 3798
		// (get) Token: 0x06002C99 RID: 11417 RVA: 0x000FE078 File Offset: 0x000FC278
		// (set) Token: 0x06002C9A RID: 11418 RVA: 0x000FE0C4 File Offset: 0x000FC2C4
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISaveable.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Abstract_Virtual_New_get_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISaveable.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Abstract_Virtual_New_set_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000ED7 RID: 3799
		// (get) Token: 0x06002C9B RID: 11419 RVA: 0x000FE114 File Offset: 0x000FC314
		// (set) Token: 0x06002C9C RID: 11420 RVA: 0x000FE160 File Offset: 0x000FC360
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISaveable.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Abstract_Virtual_New_get_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISaveable.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Abstract_Virtual_New_set_Void_List_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000ED8 RID: 3800
		// (get) Token: 0x06002C9D RID: 11421 RVA: 0x000FE1B0 File Offset: 0x000FC3B0
		// (set) Token: 0x06002C9E RID: 11422 RVA: 0x000FE1F8 File Offset: 0x000FC3F8
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISaveable.NativeMethodInfoPtr_get_HasChanged_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISaveable.NativeMethodInfoPtr_set_HasChanged_Public_Abstract_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C9F RID: 11423 RVA: 0x000FE244 File Offset: 0x000FC444
		[CallerCount(0)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISaveable.NativeMethodInfoPtr_InitializeSaveable_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CA0 RID: 11424 RVA: 0x000FE280 File Offset: 0x000FC480
		[CallerCount(0)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISaveable.NativeMethodInfoPtr_GetSaveString_Public_Abstract_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002CA1 RID: 11425 RVA: 0x000FE2C4 File Offset: 0x000FC4C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124127, XrefRangeEnd = 124149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string Save(string parentFolderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentFolderPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISaveable.NativeMethodInfoPtr_Save_Public_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002CA2 RID: 11426 RVA: 0x000FE318 File Offset: 0x000FC518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124149, XrefRangeEnd = 124200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteBaseData(string parentFolderPath, string saveString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentFolderPath);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(saveString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISaveable.NativeMethodInfoPtr_WriteBaseData_Public_Virtual_New_Void_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CA3 RID: 11427 RVA: 0x000FE378 File Offset: 0x000FC578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124200, XrefRangeEnd = 124208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetLocalPath(out bool isFolder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &isFolder;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISaveable.NativeMethodInfoPtr_GetLocalPath_Public_Virtual_New_String_byref_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002CA4 RID: 11428 RVA: 0x000FE3C8 File Offset: 0x000FC5C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124208, XrefRangeEnd = 124318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CompleteSave(string parentFolderPath, bool writeDataFile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentFolderPath);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref writeDataFile;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISaveable.NativeMethodInfoPtr_CompleteSave_Public_Virtual_New_Void_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CA5 RID: 11429 RVA: 0x000FE424 File Offset: 0x000FC624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124318, XrefRangeEnd = 124324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<string> WriteData(string parentFolderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentFolderPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISaveable.NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x06002CA6 RID: 11430 RVA: 0x000FE480 File Offset: 0x000FC680
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DeleteUnapprovedFiles(string parentFolderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentFolderPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISaveable.NativeMethodInfoPtr_DeleteUnapprovedFiles_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CA7 RID: 11431 RVA: 0x000FE4D0 File Offset: 0x000FC6D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124324, XrefRangeEnd = 124342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetContainerFolder(string parentFolderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentFolderPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISaveable.NativeMethodInfoPtr_GetContainerFolder_Public_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002CA8 RID: 11432 RVA: 0x000FE524 File Offset: 0x000FC724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124342, XrefRangeEnd = 124396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string WriteSubfile(string parentPath, string localPath_NoExtensions, string contents)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentPath);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localPath_NoExtensions);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(contents);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISaveable.NativeMethodInfoPtr_WriteSubfile_Public_Virtual_New_String_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002CA9 RID: 11433 RVA: 0x000FE59C File Offset: 0x000FC79C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124396, XrefRangeEnd = 124464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string WriteFolder(string parentPath, string localPath_NoExtensions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentPath);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localPath_NoExtensions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISaveable.NativeMethodInfoPtr_WriteFolder_Public_Virtual_New_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002CAA RID: 11434 RVA: 0x000FE604 File Offset: 0x000FC804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124464, XrefRangeEnd = 124472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool TryLoadFile(string parentPath, string fileName, out string contents)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentPath);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fileName);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISaveable.NativeMethodInfoPtr_TryLoadFile_Public_Virtual_New_Boolean_String_String_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			contents = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06002CAB RID: 11435 RVA: 0x000FE68C File Offset: 0x000FC88C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124472, XrefRangeEnd = 124483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool TryLoadFile(string path, out string contents, bool autoAddExtension = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref autoAddExtension;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISaveable.NativeMethodInfoPtr_TryLoadFile_Public_Virtual_New_Boolean_String_byref_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			contents = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06002CAC RID: 11436 RVA: 0x00018070 File Offset: 0x00016270
		public ISaveable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001D94 RID: 7572
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04001D95 RID: 7573
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04001D96 RID: 7574
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Abstract_Virtual_New_get_Loader_0;

		// Token: 0x04001D97 RID: 7575
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04001D98 RID: 7576
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Abstract_Virtual_New_get_List_1_String_0;

		// Token: 0x04001D99 RID: 7577
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Abstract_Virtual_New_set_Void_List_1_String_0;

		// Token: 0x04001D9A RID: 7578
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Abstract_Virtual_New_get_List_1_String_0;

		// Token: 0x04001D9B RID: 7579
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Abstract_Virtual_New_set_Void_List_1_String_0;

		// Token: 0x04001D9C RID: 7580
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04001D9D RID: 7581
		private static readonly IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Abstract_Virtual_New_set_Void_Boolean_0;

		// Token: 0x04001D9E RID: 7582
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04001D9F RID: 7583
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Abstract_Virtual_New_String_0;

		// Token: 0x04001DA0 RID: 7584
		private static readonly IntPtr NativeMethodInfoPtr_Save_Public_Virtual_New_String_String_0;

		// Token: 0x04001DA1 RID: 7585
		private static readonly IntPtr NativeMethodInfoPtr_WriteBaseData_Public_Virtual_New_Void_String_String_0;

		// Token: 0x04001DA2 RID: 7586
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalPath_Public_Virtual_New_String_byref_Boolean_0;

		// Token: 0x04001DA3 RID: 7587
		private static readonly IntPtr NativeMethodInfoPtr_CompleteSave_Public_Virtual_New_Void_String_Boolean_0;

		// Token: 0x04001DA4 RID: 7588
		private static readonly IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0;

		// Token: 0x04001DA5 RID: 7589
		private static readonly IntPtr NativeMethodInfoPtr_DeleteUnapprovedFiles_Public_Virtual_New_Void_String_0;

		// Token: 0x04001DA6 RID: 7590
		private static readonly IntPtr NativeMethodInfoPtr_GetContainerFolder_Public_Virtual_New_String_String_0;

		// Token: 0x04001DA7 RID: 7591
		private static readonly IntPtr NativeMethodInfoPtr_WriteSubfile_Public_Virtual_New_String_String_String_String_0;

		// Token: 0x04001DA8 RID: 7592
		private static readonly IntPtr NativeMethodInfoPtr_WriteFolder_Public_Virtual_New_String_String_String_0;

		// Token: 0x04001DA9 RID: 7593
		private static readonly IntPtr NativeMethodInfoPtr_TryLoadFile_Public_Virtual_New_Boolean_String_String_byref_String_0;

		// Token: 0x04001DAA RID: 7594
		private static readonly IntPtr NativeMethodInfoPtr_TryLoadFile_Public_Virtual_New_Boolean_String_byref_String_Boolean_0;
	}
}
