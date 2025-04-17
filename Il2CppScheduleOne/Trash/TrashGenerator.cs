using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Trash
{
	// Token: 0x02000521 RID: 1313
	public class TrashGenerator : MonoBehaviour
	{
		// Token: 0x060074DE RID: 29918 RVA: 0x001FD230 File Offset: 0x001FB430
		// Note: this type is marked as 'beforefieldinit'.
		static TrashGenerator()
		{
			Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Trash", "TrashGenerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr);
			TrashGenerator.NativeFieldInfoPtr_TRASH_GENERATION_FRACTION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, "TRASH_GENERATION_FRACTION");
			TrashGenerator.NativeFieldInfoPtr_DEFAULT_TRASH_PER_M2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, "DEFAULT_TRASH_PER_M2");
			TrashGenerator.NativeFieldInfoPtr_AllGenerators = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, "AllGenerators");
			TrashGenerator.NativeFieldInfoPtr_MaxTrashCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, "MaxTrashCount");
			TrashGenerator.NativeFieldInfoPtr_generatedTrash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, "generatedTrash");
			TrashGenerator.NativeFieldInfoPtr_GroundCheckMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, "GroundCheckMask");
			TrashGenerator.NativeFieldInfoPtr_boxCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, "boxCollider");
			TrashGenerator.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			TrashGenerator.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			TrashGenerator.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, "<HasChanged>k__BackingField");
			TrashGenerator.NativeFieldInfoPtr__GUID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, "<GUID>k__BackingField");
			TrashGenerator.NativeFieldInfoPtr_StaticGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, "StaticGUID");
			TrashGenerator.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100678001);
			TrashGenerator.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100678002);
			TrashGenerator.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100678003);
			TrashGenerator.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100678004);
			TrashGenerator.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100678005);
			TrashGenerator.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100678006);
			TrashGenerator.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100678007);
			TrashGenerator.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100678008);
			TrashGenerator.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100678009);
			TrashGenerator.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100678010);
			TrashGenerator.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100678011);
			TrashGenerator.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100678012);
			TrashGenerator.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100678013);
			TrashGenerator.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100678014);
			TrashGenerator.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100678015);
			TrashGenerator.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100678016);
			TrashGenerator.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100678017);
			TrashGenerator.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100678018);
			TrashGenerator.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100678019);
			TrashGenerator.NativeMethodInfoPtr_AddGeneratedTrash_Public_Void_TrashItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100678020);
			TrashGenerator.NativeMethodInfoPtr_RemoveGeneratedTrash_Public_Void_TrashItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100678021);
			TrashGenerator.NativeMethodInfoPtr_RegenerateGUID_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100678022);
			TrashGenerator.NativeMethodInfoPtr_AutoCalculateTrashCount_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100678023);
			TrashGenerator.NativeMethodInfoPtr_GenerateMaxTrash_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100678024);
			TrashGenerator.NativeMethodInfoPtr_SleepStart_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100678025);
			TrashGenerator.NativeMethodInfoPtr_GenerateTrash_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100678026);
			TrashGenerator.NativeMethodInfoPtr_ShouldSave_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100678027);
			TrashGenerator.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100678028);
			TrashGenerator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, 100678029);
		}

		// Token: 0x17002370 RID: 9072
		// (get) Token: 0x060074DF RID: 29919 RVA: 0x001FD594 File Offset: 0x001FB794
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228235, XrefRangeEnd = 228240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17002371 RID: 9073
		// (get) Token: 0x060074E0 RID: 29920 RVA: 0x001FD5CC File Offset: 0x001FB7CC
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228240, XrefRangeEnd = 228245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17002372 RID: 9074
		// (get) Token: 0x060074E1 RID: 29921 RVA: 0x001FD604 File Offset: 0x001FB804
		public unsafe virtual Loader Loader
		{
			[CallerCount(65)]
			[CachedScanResults(RefRangeStart = 31226, RefRangeEnd = 31291, XrefRangeStart = 31226, XrefRangeEnd = 31291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr3) : null;
			}
		}

		// Token: 0x17002373 RID: 9075
		// (get) Token: 0x060074E2 RID: 29922 RVA: 0x001FD644 File Offset: 0x001FB844
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(183)]
			[CachedScanResults(RefRangeStart = 35949, RefRangeEnd = 36132, XrefRangeStart = 35949, XrefRangeEnd = 36132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002374 RID: 9076
		// (get) Token: 0x060074E3 RID: 29923 RVA: 0x001FD680 File Offset: 0x001FB880
		// (set) Token: 0x060074E4 RID: 29924 RVA: 0x001FD6C0 File Offset: 0x001FB8C0
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35354, RefRangeEnd = 35355, XrefRangeStart = 35354, XrefRangeEnd = 35355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002375 RID: 9077
		// (get) Token: 0x060074E5 RID: 29925 RVA: 0x001FD704 File Offset: 0x001FB904
		// (set) Token: 0x060074E6 RID: 29926 RVA: 0x001FD744 File Offset: 0x001FB944
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002376 RID: 9078
		// (get) Token: 0x060074E7 RID: 29927 RVA: 0x001FD788 File Offset: 0x001FB988
		// (set) Token: 0x060074E8 RID: 29928 RVA: 0x001FD7C4 File Offset: 0x001FB9C4
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002377 RID: 9079
		// (get) Token: 0x060074E9 RID: 29929 RVA: 0x001FD804 File Offset: 0x001FBA04
		// (set) Token: 0x060074EA RID: 29930 RVA: 0x001FD840 File Offset: 0x001FBA40
		public unsafe virtual Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060074EB RID: 29931 RVA: 0x001FD880 File Offset: 0x001FBA80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228245, XrefRangeEnd = 228249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetGUID(Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074EC RID: 29932 RVA: 0x001FD8C0 File Offset: 0x001FBAC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228249, XrefRangeEnd = 228259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074ED RID: 29933 RVA: 0x001FD8F4 File Offset: 0x001FBAF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228259, XrefRangeEnd = 228285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074EE RID: 29934 RVA: 0x001FD928 File Offset: 0x001FBB28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228285, XrefRangeEnd = 228291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashGenerator.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074EF RID: 29935 RVA: 0x001FD964 File Offset: 0x001FBB64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228291, XrefRangeEnd = 228295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074F0 RID: 29936 RVA: 0x001FD998 File Offset: 0x001FBB98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228295, XrefRangeEnd = 228303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074F1 RID: 29937 RVA: 0x001FD9CC File Offset: 0x001FBBCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228303, XrefRangeEnd = 228319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074F2 RID: 29938 RVA: 0x001FDA00 File Offset: 0x001FBC00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 228338, RefRangeEnd = 228340, XrefRangeStart = 228319, XrefRangeEnd = 228338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddGeneratedTrash(TrashItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_AddGeneratedTrash_Public_Void_TrashItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074F3 RID: 29939 RVA: 0x001FDA44 File Offset: 0x001FBC44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228340, XrefRangeEnd = 228356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveGeneratedTrash(TrashItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_RemoveGeneratedTrash_Public_Void_TrashItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074F4 RID: 29940 RVA: 0x001FDA88 File Offset: 0x001FBC88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228356, XrefRangeEnd = 228359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegenerateGUID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_RegenerateGUID_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074F5 RID: 29941 RVA: 0x001FDABC File Offset: 0x001FBCBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228359, XrefRangeEnd = 228373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AutoCalculateTrashCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_AutoCalculateTrashCount_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074F6 RID: 29942 RVA: 0x001FDAF0 File Offset: 0x001FBCF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228373, XrefRangeEnd = 228376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateMaxTrash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_GenerateMaxTrash_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074F7 RID: 29943 RVA: 0x001FDB24 File Offset: 0x001FBD24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228376, XrefRangeEnd = 228383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SleepStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_SleepStart_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074F8 RID: 29944 RVA: 0x001FDB58 File Offset: 0x001FBD58
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 228452, RefRangeEnd = 228454, XrefRangeStart = 228383, XrefRangeEnd = 228452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateTrash(int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_GenerateTrash_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074F9 RID: 29945 RVA: 0x001FDB98 File Offset: 0x001FBD98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 228455, RefRangeEnd = 228456, XrefRangeStart = 228454, XrefRangeEnd = 228455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShouldSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr_ShouldSave_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060074FA RID: 29946 RVA: 0x001FDBD4 File Offset: 0x001FBDD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228456, XrefRangeEnd = 228482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashGenerator.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060074FB RID: 29947 RVA: 0x001FDC18 File Offset: 0x001FBE18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228482, XrefRangeEnd = 228505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashGenerator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074FC RID: 29948 RVA: 0x00037748 File Offset: 0x00035948
		public TrashGenerator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002364 RID: 9060
		// (get) Token: 0x060074FD RID: 29949 RVA: 0x001FDC54 File Offset: 0x001FBE54
		// (set) Token: 0x060074FE RID: 29950 RVA: 0x00037751 File Offset: 0x00035951
		public unsafe static float TRASH_GENERATION_FRACTION
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TrashGenerator.NativeFieldInfoPtr_TRASH_GENERATION_FRACTION, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrashGenerator.NativeFieldInfoPtr_TRASH_GENERATION_FRACTION, (void*)(&value));
			}
		}

		// Token: 0x17002365 RID: 9061
		// (get) Token: 0x060074FF RID: 29951 RVA: 0x001FDC70 File Offset: 0x001FBE70
		// (set) Token: 0x06007500 RID: 29952 RVA: 0x0003775F File Offset: 0x0003595F
		public unsafe static float DEFAULT_TRASH_PER_M2
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TrashGenerator.NativeFieldInfoPtr_DEFAULT_TRASH_PER_M2, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrashGenerator.NativeFieldInfoPtr_DEFAULT_TRASH_PER_M2, (void*)(&value));
			}
		}

		// Token: 0x17002366 RID: 9062
		// (get) Token: 0x06007501 RID: 29953 RVA: 0x001FDC8C File Offset: 0x001FBE8C
		// (set) Token: 0x06007502 RID: 29954 RVA: 0x0003776D File Offset: 0x0003596D
		public unsafe static List<TrashGenerator> AllGenerators
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TrashGenerator.NativeFieldInfoPtr_AllGenerators, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TrashGenerator>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrashGenerator.NativeFieldInfoPtr_AllGenerators, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002367 RID: 9063
		// (get) Token: 0x06007503 RID: 29955 RVA: 0x001FDCB4 File Offset: 0x001FBEB4
		// (set) Token: 0x06007504 RID: 29956 RVA: 0x0003777F File Offset: 0x0003597F
		public unsafe int MaxTrashCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGenerator.NativeFieldInfoPtr_MaxTrashCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGenerator.NativeFieldInfoPtr_MaxTrashCount)) = value;
			}
		}

		// Token: 0x17002368 RID: 9064
		// (get) Token: 0x06007505 RID: 29957 RVA: 0x001FDCDC File Offset: 0x001FBEDC
		// (set) Token: 0x06007506 RID: 29958 RVA: 0x0003779A File Offset: 0x0003599A
		public unsafe List<TrashItem> generatedTrash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGenerator.NativeFieldInfoPtr_generatedTrash);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TrashItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGenerator.NativeFieldInfoPtr_generatedTrash), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002369 RID: 9065
		// (get) Token: 0x06007507 RID: 29959 RVA: 0x001FDD0C File Offset: 0x001FBF0C
		// (set) Token: 0x06007508 RID: 29960 RVA: 0x000377B9 File Offset: 0x000359B9
		public unsafe LayerMask GroundCheckMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGenerator.NativeFieldInfoPtr_GroundCheckMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGenerator.NativeFieldInfoPtr_GroundCheckMask)) = value;
			}
		}

		// Token: 0x1700236A RID: 9066
		// (get) Token: 0x06007509 RID: 29961 RVA: 0x001FDD34 File Offset: 0x001FBF34
		// (set) Token: 0x0600750A RID: 29962 RVA: 0x000377D4 File Offset: 0x000359D4
		public unsafe BoxCollider boxCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGenerator.NativeFieldInfoPtr_boxCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGenerator.NativeFieldInfoPtr_boxCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700236B RID: 9067
		// (get) Token: 0x0600750B RID: 29963 RVA: 0x001FDD64 File Offset: 0x001FBF64
		// (set) Token: 0x0600750C RID: 29964 RVA: 0x000377F3 File Offset: 0x000359F3
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGenerator.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGenerator.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700236C RID: 9068
		// (get) Token: 0x0600750D RID: 29965 RVA: 0x001FDD94 File Offset: 0x001FBF94
		// (set) Token: 0x0600750E RID: 29966 RVA: 0x00037812 File Offset: 0x00035A12
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGenerator.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGenerator.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700236D RID: 9069
		// (get) Token: 0x0600750F RID: 29967 RVA: 0x001FDDC4 File Offset: 0x001FBFC4
		// (set) Token: 0x06007510 RID: 29968 RVA: 0x00037831 File Offset: 0x00035A31
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGenerator.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGenerator.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x1700236E RID: 9070
		// (get) Token: 0x06007511 RID: 29969 RVA: 0x001FDDEC File Offset: 0x001FBFEC
		// (set) Token: 0x06007512 RID: 29970 RVA: 0x0003784C File Offset: 0x00035A4C
		public unsafe Guid _GUID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGenerator.NativeFieldInfoPtr__GUID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGenerator.NativeFieldInfoPtr__GUID_k__BackingField)) = value;
			}
		}

		// Token: 0x1700236F RID: 9071
		// (get) Token: 0x06007513 RID: 29971 RVA: 0x001FDE14 File Offset: 0x001FC014
		// (set) Token: 0x06007514 RID: 29972 RVA: 0x00037867 File Offset: 0x00035A67
		public unsafe string StaticGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGenerator.NativeFieldInfoPtr_StaticGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGenerator.NativeFieldInfoPtr_StaticGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04004FCF RID: 20431
		private static readonly IntPtr NativeFieldInfoPtr_TRASH_GENERATION_FRACTION;

		// Token: 0x04004FD0 RID: 20432
		private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_TRASH_PER_M2;

		// Token: 0x04004FD1 RID: 20433
		private static readonly IntPtr NativeFieldInfoPtr_AllGenerators;

		// Token: 0x04004FD2 RID: 20434
		private static readonly IntPtr NativeFieldInfoPtr_MaxTrashCount;

		// Token: 0x04004FD3 RID: 20435
		private static readonly IntPtr NativeFieldInfoPtr_generatedTrash;

		// Token: 0x04004FD4 RID: 20436
		private static readonly IntPtr NativeFieldInfoPtr_GroundCheckMask;

		// Token: 0x04004FD5 RID: 20437
		private static readonly IntPtr NativeFieldInfoPtr_boxCollider;

		// Token: 0x04004FD6 RID: 20438
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x04004FD7 RID: 20439
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x04004FD8 RID: 20440
		private static readonly IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x04004FD9 RID: 20441
		private static readonly IntPtr NativeFieldInfoPtr__GUID_k__BackingField;

		// Token: 0x04004FDA RID: 20442
		private static readonly IntPtr NativeFieldInfoPtr_StaticGUID;

		// Token: 0x04004FDB RID: 20443
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04004FDC RID: 20444
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04004FDD RID: 20445
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x04004FDE RID: 20446
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04004FDF RID: 20447
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04004FE0 RID: 20448
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04004FE1 RID: 20449
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04004FE2 RID: 20450
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04004FE3 RID: 20451
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04004FE4 RID: 20452
		private static readonly IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04004FE5 RID: 20453
		private static readonly IntPtr NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0;

		// Token: 0x04004FE6 RID: 20454
		private static readonly IntPtr NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0;

		// Token: 0x04004FE7 RID: 20455
		private static readonly IntPtr NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0;

		// Token: 0x04004FE8 RID: 20456
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04004FE9 RID: 20457
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04004FEA RID: 20458
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x04004FEB RID: 20459
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04004FEC RID: 20460
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04004FED RID: 20461
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x04004FEE RID: 20462
		private static readonly IntPtr NativeMethodInfoPtr_AddGeneratedTrash_Public_Void_TrashItem_0;

		// Token: 0x04004FEF RID: 20463
		private static readonly IntPtr NativeMethodInfoPtr_RemoveGeneratedTrash_Public_Void_TrashItem_0;

		// Token: 0x04004FF0 RID: 20464
		private static readonly IntPtr NativeMethodInfoPtr_RegenerateGUID_Private_Void_0;

		// Token: 0x04004FF1 RID: 20465
		private static readonly IntPtr NativeMethodInfoPtr_AutoCalculateTrashCount_Private_Void_0;

		// Token: 0x04004FF2 RID: 20466
		private static readonly IntPtr NativeMethodInfoPtr_GenerateMaxTrash_Private_Void_0;

		// Token: 0x04004FF3 RID: 20467
		private static readonly IntPtr NativeMethodInfoPtr_SleepStart_Private_Void_0;

		// Token: 0x04004FF4 RID: 20468
		private static readonly IntPtr NativeMethodInfoPtr_GenerateTrash_Private_Void_Int32_0;

		// Token: 0x04004FF5 RID: 20469
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSave_Public_Boolean_0;

		// Token: 0x04004FF6 RID: 20470
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x04004FF7 RID: 20471
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A91 RID: 2705
		[ObfuscatedName("ScheduleOne.Trash.TrashGenerator+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D284 RID: 53892 RVA: 0x00325A9C File Offset: 0x00323C9C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TrashGenerator.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TrashGenerator>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashGenerator.__c>.NativeClassPtr);
				TrashGenerator.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashGenerator.__c>.NativeClassPtr, "<>9");
				TrashGenerator.__c.NativeFieldInfoPtr___9__47_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashGenerator.__c>.NativeClassPtr, "<>9__47_0");
				TrashGenerator.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator.__c>.NativeClassPtr, 100678032);
				TrashGenerator.__c.NativeMethodInfoPtr__GetSaveString_b__47_0_Internal_String_TrashItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGenerator.__c>.NativeClassPtr, 100678033);
			}

			// Token: 0x0600D285 RID: 53893 RVA: 0x00325B18 File Offset: 0x00323D18
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashGenerator.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D286 RID: 53894 RVA: 0x00325B54 File Offset: 0x00323D54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228234, XrefRangeEnd = 228235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _GetSaveString_b__47_0(TrashItem x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGenerator.__c.NativeMethodInfoPtr__GetSaveString_b__47_0_Internal_String_TrashItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600D287 RID: 53895 RVA: 0x0006679F File Offset: 0x0006499F
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004150 RID: 16720
			// (get) Token: 0x0600D288 RID: 53896 RVA: 0x00325B9C File Offset: 0x00323D9C
			// (set) Token: 0x0600D289 RID: 53897 RVA: 0x000667A8 File Offset: 0x000649A8
			public unsafe static TrashGenerator.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TrashGenerator.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashGenerator.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TrashGenerator.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004151 RID: 16721
			// (get) Token: 0x0600D28A RID: 53898 RVA: 0x00325BC4 File Offset: 0x00323DC4
			// (set) Token: 0x0600D28B RID: 53899 RVA: 0x000667BA File Offset: 0x000649BA
			public unsafe static Converter<TrashItem, string> __9__47_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TrashGenerator.__c.NativeFieldInfoPtr___9__47_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Converter<TrashItem, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TrashGenerator.__c.NativeFieldInfoPtr___9__47_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008DF2 RID: 36338
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008DF3 RID: 36339
			private static readonly IntPtr NativeFieldInfoPtr___9__47_0;

			// Token: 0x04008DF4 RID: 36340
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008DF5 RID: 36341
			private static readonly IntPtr NativeMethodInfoPtr__GetSaveString_b__47_0_Internal_String_TrashItem_0;
		}
	}
}
