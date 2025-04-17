using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.NPCs
{
	// Token: 0x020002D8 RID: 728
	public class NPCManager : NetworkSingleton<NPCManager>
	{
		// Token: 0x060034D0 RID: 13520 RVA: 0x0011A318 File Offset: 0x00118518
		// Note: this type is marked as 'beforefieldinit'.
		static NPCManager()
		{
			Il2CppClassPointerStore<NPCManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs", "NPCManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCManager>.NativeClassPtr);
			NPCManager.NativeFieldInfoPtr_NPCRegistry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCManager>.NativeClassPtr, "NPCRegistry");
			NPCManager.NativeFieldInfoPtr_NPCWarpPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCManager>.NativeClassPtr, "NPCWarpPoints");
			NPCManager.NativeFieldInfoPtr_NPCContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCManager>.NativeClassPtr, "NPCContainer");
			NPCManager.NativeFieldInfoPtr_BotanistPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCManager>.NativeClassPtr, "BotanistPrefab");
			NPCManager.NativeFieldInfoPtr_PackagerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCManager>.NativeClassPtr, "PackagerPrefab");
			NPCManager.NativeFieldInfoPtr_NPCPoIPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCManager>.NativeClassPtr, "NPCPoIPrefab");
			NPCManager.NativeFieldInfoPtr_PotentialCustomerPoIPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCManager>.NativeClassPtr, "PotentialCustomerPoIPrefab");
			NPCManager.NativeFieldInfoPtr_PotentialDealerPoIPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCManager>.NativeClassPtr, "PotentialDealerPoIPrefab");
			NPCManager.NativeFieldInfoPtr_loader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCManager>.NativeClassPtr, "loader");
			NPCManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCManager>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			NPCManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCManager>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			NPCManager.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCManager>.NativeClassPtr, "<HasChanged>k__BackingField");
			NPCManager.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCManager>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.NPCManagerAssembly-CSharp.dll_Excuted");
			NPCManager.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCManager>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.NPCManagerAssembly-CSharp.dll_Excuted");
			NPCManager.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCManager>.NativeClassPtr, 100669273);
			NPCManager.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCManager>.NativeClassPtr, 100669274);
			NPCManager.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCManager>.NativeClassPtr, 100669275);
			NPCManager.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCManager>.NativeClassPtr, 100669276);
			NPCManager.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCManager>.NativeClassPtr, 100669277);
			NPCManager.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCManager>.NativeClassPtr, 100669278);
			NPCManager.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCManager>.NativeClassPtr, 100669279);
			NPCManager.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCManager>.NativeClassPtr, 100669280);
			NPCManager.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCManager>.NativeClassPtr, 100669281);
			NPCManager.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCManager>.NativeClassPtr, 100669282);
			NPCManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCManager>.NativeClassPtr, 100669283);
			NPCManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCManager>.NativeClassPtr, 100669284);
			NPCManager.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCManager>.NativeClassPtr, 100669285);
			NPCManager.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCManager>.NativeClassPtr, 100669286);
			NPCManager.NativeMethodInfoPtr_GetNPC_Public_Static_NPC_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCManager>.NativeClassPtr, 100669287);
			NPCManager.NativeMethodInfoPtr_GetNPCsInRegion_Public_Static_List_1_NPC_EMapRegion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCManager>.NativeClassPtr, 100669288);
			NPCManager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCManager>.NativeClassPtr, 100669289);
			NPCManager.NativeMethodInfoPtr_GetOrderedDistanceWarpPoints_Public_List_1_Transform_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCManager>.NativeClassPtr, 100669290);
			NPCManager.NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCManager>.NativeClassPtr, 100669291);
			NPCManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCManager>.NativeClassPtr, 100669292);
			NPCManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCManager>.NativeClassPtr, 100669294);
			NPCManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCManager>.NativeClassPtr, 100669295);
			NPCManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCManager>.NativeClassPtr, 100669296);
			NPCManager.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCManager>.NativeClassPtr, 100669297);
		}

		// Token: 0x17001111 RID: 4369
		// (get) Token: 0x060034D1 RID: 13521 RVA: 0x0011A640 File Offset: 0x00118840
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136375, XrefRangeEnd = 136377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCManager.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001112 RID: 4370
		// (get) Token: 0x060034D2 RID: 13522 RVA: 0x0011A678 File Offset: 0x00118878
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136377, XrefRangeEnd = 136379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCManager.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001113 RID: 4371
		// (get) Token: 0x060034D3 RID: 13523 RVA: 0x0011A6B0 File Offset: 0x001188B0
		public unsafe virtual Loader Loader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCManager.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr3) : null;
			}
		}

		// Token: 0x17001114 RID: 4372
		// (get) Token: 0x060034D4 RID: 13524 RVA: 0x0011A6F0 File Offset: 0x001188F0
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 30137, RefRangeEnd = 30157, XrefRangeStart = 30137, XrefRangeEnd = 30157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCManager.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001115 RID: 4373
		// (get) Token: 0x060034D5 RID: 13525 RVA: 0x0011A72C File Offset: 0x0011892C
		// (set) Token: 0x060034D6 RID: 13526 RVA: 0x0011A76C File Offset: 0x0011896C
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCManager.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 115138, RefRangeEnd = 115149, XrefRangeStart = 115138, XrefRangeEnd = 115149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCManager.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001116 RID: 4374
		// (get) Token: 0x060034D7 RID: 13527 RVA: 0x0011A7B0 File Offset: 0x001189B0
		// (set) Token: 0x060034D8 RID: 13528 RVA: 0x0011A7F0 File Offset: 0x001189F0
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCManager.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 115150, RefRangeEnd = 115151, XrefRangeStart = 115150, XrefRangeEnd = 115151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCManager.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001117 RID: 4375
		// (get) Token: 0x060034D9 RID: 13529 RVA: 0x0011A834 File Offset: 0x00118A34
		// (set) Token: 0x060034DA RID: 13530 RVA: 0x0011A870 File Offset: 0x00118A70
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCManager.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCManager.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034DB RID: 13531 RVA: 0x0011A8B0 File Offset: 0x00118AB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136379, XrefRangeEnd = 136382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034DC RID: 13532 RVA: 0x0011A8EC File Offset: 0x00118AEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136382, XrefRangeEnd = 136406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034DD RID: 13533 RVA: 0x0011A928 File Offset: 0x00118B28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136406, XrefRangeEnd = 136412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCManager.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034DE RID: 13534 RVA: 0x0011A964 File Offset: 0x00118B64
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCManager.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034DF RID: 13535 RVA: 0x0011A998 File Offset: 0x00118B98
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 136429, RefRangeEnd = 136446, XrefRangeStart = 136412, XrefRangeEnd = 136429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NPC GetNPC(string id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCManager.NativeMethodInfoPtr_GetNPC_Public_Static_NPC_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr3) : null;
		}

		// Token: 0x060034E0 RID: 13536 RVA: 0x0011A9DC File Offset: 0x00118BDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 136477, RefRangeEnd = 136478, XrefRangeStart = 136446, XrefRangeEnd = 136477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<NPC> GetNPCsInRegion(EMapRegion region)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref region;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCManager.NativeMethodInfoPtr_GetNPCsInRegion_Public_Static_List_1_NPC_EMapRegion_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<NPC>>(intPtr3) : null;
		}

		// Token: 0x060034E1 RID: 13537 RVA: 0x0011AA1C File Offset: 0x00118C1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136478, XrefRangeEnd = 136480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCManager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060034E2 RID: 13538 RVA: 0x0011AA60 File Offset: 0x00118C60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 136503, RefRangeEnd = 136504, XrefRangeStart = 136480, XrefRangeEnd = 136503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Transform> GetOrderedDistanceWarpPoints(Vector3 origin)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref origin;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCManager.NativeMethodInfoPtr_GetOrderedDistanceWarpPoints_Public_List_1_Transform_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr3) : null;
		}

		// Token: 0x060034E3 RID: 13539 RVA: 0x0011AAAC File Offset: 0x00118CAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136504, XrefRangeEnd = 136541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<string> WriteData(string parentFolderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentFolderPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCManager.NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x060034E4 RID: 13540 RVA: 0x0011AB08 File Offset: 0x00118D08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136541, XrefRangeEnd = 136561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034E5 RID: 13541 RVA: 0x0011AB44 File Offset: 0x00118D44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136561, XrefRangeEnd = 136564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034E6 RID: 13542 RVA: 0x0011AB80 File Offset: 0x00118D80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136564, XrefRangeEnd = 136567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034E7 RID: 13543 RVA: 0x0011ABBC File Offset: 0x00118DBC
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034E8 RID: 13544 RVA: 0x0011ABF8 File Offset: 0x00118DF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136567, XrefRangeEnd = 136570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCManager.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034E9 RID: 13545 RVA: 0x0001BD0A File Offset: 0x00019F0A
		public NPCManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001103 RID: 4355
		// (get) Token: 0x060034EA RID: 13546 RVA: 0x0011AC34 File Offset: 0x00118E34
		// (set) Token: 0x060034EB RID: 13547 RVA: 0x0001BD13 File Offset: 0x00019F13
		public unsafe static List<NPC> NPCRegistry
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NPCManager.NativeFieldInfoPtr_NPCRegistry, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPC>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCManager.NativeFieldInfoPtr_NPCRegistry, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001104 RID: 4356
		// (get) Token: 0x060034EC RID: 13548 RVA: 0x0011AC5C File Offset: 0x00118E5C
		// (set) Token: 0x060034ED RID: 13549 RVA: 0x0001BD25 File Offset: 0x00019F25
		public unsafe Il2CppReferenceArray<Transform> NPCWarpPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCManager.NativeFieldInfoPtr_NPCWarpPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCManager.NativeFieldInfoPtr_NPCWarpPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001105 RID: 4357
		// (get) Token: 0x060034EE RID: 13550 RVA: 0x0011AC8C File Offset: 0x00118E8C
		// (set) Token: 0x060034EF RID: 13551 RVA: 0x0001BD44 File Offset: 0x00019F44
		public unsafe Transform NPCContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCManager.NativeFieldInfoPtr_NPCContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCManager.NativeFieldInfoPtr_NPCContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001106 RID: 4358
		// (get) Token: 0x060034F0 RID: 13552 RVA: 0x0011ACBC File Offset: 0x00118EBC
		// (set) Token: 0x060034F1 RID: 13553 RVA: 0x0001BD63 File Offset: 0x00019F63
		public unsafe GameObject BotanistPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCManager.NativeFieldInfoPtr_BotanistPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCManager.NativeFieldInfoPtr_BotanistPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001107 RID: 4359
		// (get) Token: 0x060034F2 RID: 13554 RVA: 0x0011ACEC File Offset: 0x00118EEC
		// (set) Token: 0x060034F3 RID: 13555 RVA: 0x0001BD82 File Offset: 0x00019F82
		public unsafe GameObject PackagerPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCManager.NativeFieldInfoPtr_PackagerPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCManager.NativeFieldInfoPtr_PackagerPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001108 RID: 4360
		// (get) Token: 0x060034F4 RID: 13556 RVA: 0x0011AD1C File Offset: 0x00118F1C
		// (set) Token: 0x060034F5 RID: 13557 RVA: 0x0001BDA1 File Offset: 0x00019FA1
		public unsafe NPCPoI NPCPoIPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCManager.NativeFieldInfoPtr_NPCPoIPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCPoI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCManager.NativeFieldInfoPtr_NPCPoIPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001109 RID: 4361
		// (get) Token: 0x060034F6 RID: 13558 RVA: 0x0011AD4C File Offset: 0x00118F4C
		// (set) Token: 0x060034F7 RID: 13559 RVA: 0x0001BDC0 File Offset: 0x00019FC0
		public unsafe NPCPoI PotentialCustomerPoIPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCManager.NativeFieldInfoPtr_PotentialCustomerPoIPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCPoI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCManager.NativeFieldInfoPtr_PotentialCustomerPoIPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700110A RID: 4362
		// (get) Token: 0x060034F8 RID: 13560 RVA: 0x0011AD7C File Offset: 0x00118F7C
		// (set) Token: 0x060034F9 RID: 13561 RVA: 0x0001BDDF File Offset: 0x00019FDF
		public unsafe NPCPoI PotentialDealerPoIPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCManager.NativeFieldInfoPtr_PotentialDealerPoIPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCPoI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCManager.NativeFieldInfoPtr_PotentialDealerPoIPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700110B RID: 4363
		// (get) Token: 0x060034FA RID: 13562 RVA: 0x0011ADAC File Offset: 0x00118FAC
		// (set) Token: 0x060034FB RID: 13563 RVA: 0x0001BDFE File Offset: 0x00019FFE
		public unsafe NPCsLoader loader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCManager.NativeFieldInfoPtr_loader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCsLoader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCManager.NativeFieldInfoPtr_loader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700110C RID: 4364
		// (get) Token: 0x060034FC RID: 13564 RVA: 0x0011ADDC File Offset: 0x00118FDC
		// (set) Token: 0x060034FD RID: 13565 RVA: 0x0001BE1D File Offset: 0x0001A01D
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700110D RID: 4365
		// (get) Token: 0x060034FE RID: 13566 RVA: 0x0011AE0C File Offset: 0x0011900C
		// (set) Token: 0x060034FF RID: 13567 RVA: 0x0001BE3C File Offset: 0x0001A03C
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700110E RID: 4366
		// (get) Token: 0x06003500 RID: 13568 RVA: 0x0011AE3C File Offset: 0x0011903C
		// (set) Token: 0x06003501 RID: 13569 RVA: 0x0001BE5B File Offset: 0x0001A05B
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCManager.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCManager.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x1700110F RID: 4367
		// (get) Token: 0x06003502 RID: 13570 RVA: 0x0011AE64 File Offset: 0x00119064
		// (set) Token: 0x06003503 RID: 13571 RVA: 0x0001BE76 File Offset: 0x0001A076
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCManager.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCManager.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001110 RID: 4368
		// (get) Token: 0x06003504 RID: 13572 RVA: 0x0011AE8C File Offset: 0x0011908C
		// (set) Token: 0x06003505 RID: 13573 RVA: 0x0001BE91 File Offset: 0x0001A091
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCManager.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCManager.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x0400227C RID: 8828
		private static readonly IntPtr NativeFieldInfoPtr_NPCRegistry;

		// Token: 0x0400227D RID: 8829
		private static readonly IntPtr NativeFieldInfoPtr_NPCWarpPoints;

		// Token: 0x0400227E RID: 8830
		private static readonly IntPtr NativeFieldInfoPtr_NPCContainer;

		// Token: 0x0400227F RID: 8831
		private static readonly IntPtr NativeFieldInfoPtr_BotanistPrefab;

		// Token: 0x04002280 RID: 8832
		private static readonly IntPtr NativeFieldInfoPtr_PackagerPrefab;

		// Token: 0x04002281 RID: 8833
		private static readonly IntPtr NativeFieldInfoPtr_NPCPoIPrefab;

		// Token: 0x04002282 RID: 8834
		private static readonly IntPtr NativeFieldInfoPtr_PotentialCustomerPoIPrefab;

		// Token: 0x04002283 RID: 8835
		private static readonly IntPtr NativeFieldInfoPtr_PotentialDealerPoIPrefab;

		// Token: 0x04002284 RID: 8836
		private static readonly IntPtr NativeFieldInfoPtr_loader;

		// Token: 0x04002285 RID: 8837
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x04002286 RID: 8838
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x04002287 RID: 8839
		private static readonly IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x04002288 RID: 8840
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002289 RID: 8841
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400228A RID: 8842
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400228B RID: 8843
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400228C RID: 8844
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x0400228D RID: 8845
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400228E RID: 8846
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x0400228F RID: 8847
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04002290 RID: 8848
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04002291 RID: 8849
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04002292 RID: 8850
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04002293 RID: 8851
		private static readonly IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04002294 RID: 8852
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04002295 RID: 8853
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_1;

		// Token: 0x04002296 RID: 8854
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x04002297 RID: 8855
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04002298 RID: 8856
		private static readonly IntPtr NativeMethodInfoPtr_GetNPC_Public_Static_NPC_String_0;

		// Token: 0x04002299 RID: 8857
		private static readonly IntPtr NativeMethodInfoPtr_GetNPCsInRegion_Public_Static_List_1_NPC_EMapRegion_0;

		// Token: 0x0400229A RID: 8858
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x0400229B RID: 8859
		private static readonly IntPtr NativeMethodInfoPtr_GetOrderedDistanceWarpPoints_Public_List_1_Transform_Vector3_0;

		// Token: 0x0400229C RID: 8860
		private static readonly IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0;

		// Token: 0x0400229D RID: 8861
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400229E RID: 8862
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400229F RID: 8863
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040022A0 RID: 8864
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040022A1 RID: 8865
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x0200091D RID: 2333
		[ObfuscatedName("ScheduleOne.NPCs.NPCManager+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600C63F RID: 50751 RVA: 0x00302898 File Offset: 0x00300A98
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<NPCManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCManager.__c>.NativeClassPtr);
				NPCManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCManager.__c>.NativeClassPtr, "<>9");
				NPCManager.__c.NativeFieldInfoPtr___9__30_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCManager.__c>.NativeClassPtr, "<>9__30_0");
				NPCManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCManager.__c>.NativeClassPtr, 100669299);
				NPCManager.__c.NativeMethodInfoPtr__Start_b__30_0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCManager.__c>.NativeClassPtr, 100669300);
			}

			// Token: 0x0600C640 RID: 50752 RVA: 0x00302914 File Offset: 0x00300B14
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCManager.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C641 RID: 50753 RVA: 0x00302950 File Offset: 0x00300B50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136368, XrefRangeEnd = 136374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__30_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCManager.__c.NativeMethodInfoPtr__Start_b__30_0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C642 RID: 50754 RVA: 0x000607FE File Offset: 0x0005E9FE
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003DC6 RID: 15814
			// (get) Token: 0x0600C643 RID: 50755 RVA: 0x00302984 File Offset: 0x00300B84
			// (set) Token: 0x0600C644 RID: 50756 RVA: 0x00060807 File Offset: 0x0005EA07
			public unsafe static NPCManager.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003DC7 RID: 15815
			// (get) Token: 0x0600C645 RID: 50757 RVA: 0x003029AC File Offset: 0x00300BAC
			// (set) Token: 0x0600C646 RID: 50758 RVA: 0x00060819 File Offset: 0x0005EA19
			public unsafe static UnityAction __9__30_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCManager.__c.NativeFieldInfoPtr___9__30_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCManager.__c.NativeFieldInfoPtr___9__30_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008632 RID: 34354
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008633 RID: 34355
			private static readonly IntPtr NativeFieldInfoPtr___9__30_0;

			// Token: 0x04008634 RID: 34356
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008635 RID: 34357
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__30_0_Internal_Void_0;
		}

		// Token: 0x0200091E RID: 2334
		[ObfuscatedName("ScheduleOne.NPCs.NPCManager+<>c__DisplayClass36_0")]
		public sealed class __c__DisplayClass36_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C647 RID: 50759 RVA: 0x003029D4 File Offset: 0x00300BD4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass36_0()
			{
				Il2CppClassPointerStore<NPCManager.__c__DisplayClass36_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCManager>.NativeClassPtr, "<>c__DisplayClass36_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCManager.__c__DisplayClass36_0>.NativeClassPtr);
				NPCManager.__c__DisplayClass36_0.NativeFieldInfoPtr_origin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCManager.__c__DisplayClass36_0>.NativeClassPtr, "origin");
				NPCManager.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCManager.__c__DisplayClass36_0>.NativeClassPtr, 100669301);
				NPCManager.__c__DisplayClass36_0.NativeMethodInfoPtr__GetOrderedDistanceWarpPoints_b__0_Internal_Single_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCManager.__c__DisplayClass36_0>.NativeClassPtr, 100669302);
			}

			// Token: 0x0600C648 RID: 50760 RVA: 0x00302A3C File Offset: 0x00300C3C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass36_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCManager.__c__DisplayClass36_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCManager.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C649 RID: 50761 RVA: 0x00302A78 File Offset: 0x00300C78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136374, XrefRangeEnd = 136375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _GetOrderedDistanceWarpPoints_b__0(Transform x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCManager.__c__DisplayClass36_0.NativeMethodInfoPtr__GetOrderedDistanceWarpPoints_b__0_Internal_Single_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C64A RID: 50762 RVA: 0x0006082B File Offset: 0x0005EA2B
			public __c__DisplayClass36_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003DC8 RID: 15816
			// (get) Token: 0x0600C64B RID: 50763 RVA: 0x00302AC8 File Offset: 0x00300CC8
			// (set) Token: 0x0600C64C RID: 50764 RVA: 0x00060834 File Offset: 0x0005EA34
			public unsafe Vector3 origin
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCManager.__c__DisplayClass36_0.NativeFieldInfoPtr_origin);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCManager.__c__DisplayClass36_0.NativeFieldInfoPtr_origin)) = value;
				}
			}

			// Token: 0x04008636 RID: 34358
			private static readonly IntPtr NativeFieldInfoPtr_origin;

			// Token: 0x04008637 RID: 34359
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008638 RID: 34360
			private static readonly IntPtr NativeMethodInfoPtr__GetOrderedDistanceWarpPoints_b__0_Internal_Single_Transform_0;
		}
	}
}
