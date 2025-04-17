using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Property
{
	// Token: 0x0200050B RID: 1291
	public class BusinessManager : Singleton<BusinessManager>
	{
		// Token: 0x06007251 RID: 29265 RVA: 0x001F3FF0 File Offset: 0x001F21F0
		// Note: this type is marked as 'beforefieldinit'.
		static BusinessManager()
		{
			Il2CppClassPointerStore<BusinessManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Property", "BusinessManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BusinessManager>.NativeClassPtr);
			BusinessManager.NativeFieldInfoPtr_loader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BusinessManager>.NativeClassPtr, "loader");
			BusinessManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BusinessManager>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			BusinessManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BusinessManager>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			BusinessManager.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BusinessManager>.NativeClassPtr, "<HasChanged>k__BackingField");
			BusinessManager.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BusinessManager>.NativeClassPtr, 100677640);
			BusinessManager.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BusinessManager>.NativeClassPtr, 100677641);
			BusinessManager.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BusinessManager>.NativeClassPtr, 100677642);
			BusinessManager.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BusinessManager>.NativeClassPtr, 100677643);
			BusinessManager.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BusinessManager>.NativeClassPtr, 100677644);
			BusinessManager.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BusinessManager>.NativeClassPtr, 100677645);
			BusinessManager.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BusinessManager>.NativeClassPtr, 100677646);
			BusinessManager.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BusinessManager>.NativeClassPtr, 100677647);
			BusinessManager.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BusinessManager>.NativeClassPtr, 100677648);
			BusinessManager.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BusinessManager>.NativeClassPtr, 100677649);
			BusinessManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BusinessManager>.NativeClassPtr, 100677650);
			BusinessManager.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BusinessManager>.NativeClassPtr, 100677651);
			BusinessManager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BusinessManager>.NativeClassPtr, 100677652);
			BusinessManager.NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BusinessManager>.NativeClassPtr, 100677653);
			BusinessManager.NativeMethodInfoPtr_LoadBusiness_Public_Void_BusinessData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BusinessManager>.NativeClassPtr, 100677654);
			BusinessManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BusinessManager>.NativeClassPtr, 100677655);
		}

		// Token: 0x170022A5 RID: 8869
		// (get) Token: 0x06007252 RID: 29266 RVA: 0x001F41B0 File Offset: 0x001F23B0
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224162, XrefRangeEnd = 224164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BusinessManager.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170022A6 RID: 8870
		// (get) Token: 0x06007253 RID: 29267 RVA: 0x001F41E8 File Offset: 0x001F23E8
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224164, XrefRangeEnd = 224166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BusinessManager.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170022A7 RID: 8871
		// (get) Token: 0x06007254 RID: 29268 RVA: 0x001F4220 File Offset: 0x001F2420
		public unsafe virtual Loader Loader
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19639, RefRangeEnd = 19642, XrefRangeStart = 19639, XrefRangeEnd = 19642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BusinessManager.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr3) : null;
			}
		}

		// Token: 0x170022A8 RID: 8872
		// (get) Token: 0x06007255 RID: 29269 RVA: 0x001F4260 File Offset: 0x001F2460
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 30137, RefRangeEnd = 30157, XrefRangeStart = 30137, XrefRangeEnd = 30157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BusinessManager.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170022A9 RID: 8873
		// (get) Token: 0x06007256 RID: 29270 RVA: 0x001F429C File Offset: 0x001F249C
		// (set) Token: 0x06007257 RID: 29271 RVA: 0x001F42DC File Offset: 0x001F24DC
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 19646, RefRangeEnd = 19660, XrefRangeStart = 19646, XrefRangeEnd = 19660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BusinessManager.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 19661, RefRangeEnd = 19662, XrefRangeStart = 19661, XrefRangeEnd = 19662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BusinessManager.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170022AA RID: 8874
		// (get) Token: 0x06007258 RID: 29272 RVA: 0x001F4320 File Offset: 0x001F2520
		// (set) Token: 0x06007259 RID: 29273 RVA: 0x001F4360 File Offset: 0x001F2560
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 19662, RefRangeEnd = 19669, XrefRangeStart = 19662, XrefRangeEnd = 19669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BusinessManager.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BusinessManager.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170022AB RID: 8875
		// (get) Token: 0x0600725A RID: 29274 RVA: 0x001F43A4 File Offset: 0x001F25A4
		// (set) Token: 0x0600725B RID: 29275 RVA: 0x001F43E0 File Offset: 0x001F25E0
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BusinessManager.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BusinessManager.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600725C RID: 29276 RVA: 0x001F4420 File Offset: 0x001F2620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224166, XrefRangeEnd = 224169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BusinessManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600725D RID: 29277 RVA: 0x001F445C File Offset: 0x001F265C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224169, XrefRangeEnd = 224175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BusinessManager.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600725E RID: 29278 RVA: 0x001F4498 File Offset: 0x001F2698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224175, XrefRangeEnd = 224177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BusinessManager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600725F RID: 29279 RVA: 0x001F44DC File Offset: 0x001F26DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224177, XrefRangeEnd = 224228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<string> WriteData(string parentFolderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentFolderPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BusinessManager.NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x06007260 RID: 29280 RVA: 0x001F4538 File Offset: 0x001F2738
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 224271, RefRangeEnd = 224272, XrefRangeStart = 224228, XrefRangeEnd = 224271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadBusiness(BusinessData businessData, string containerPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(businessData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(containerPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BusinessManager.NativeMethodInfoPtr_LoadBusiness_Public_Void_BusinessData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007261 RID: 29281 RVA: 0x001F458C File Offset: 0x001F278C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224272, XrefRangeEnd = 224292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BusinessManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BusinessManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BusinessManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007262 RID: 29282 RVA: 0x000365EC File Offset: 0x000347EC
		public BusinessManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170022A1 RID: 8865
		// (get) Token: 0x06007263 RID: 29283 RVA: 0x001F45C8 File Offset: 0x001F27C8
		// (set) Token: 0x06007264 RID: 29284 RVA: 0x000365F5 File Offset: 0x000347F5
		public unsafe BusinessesLoader loader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BusinessManager.NativeFieldInfoPtr_loader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BusinessesLoader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BusinessManager.NativeFieldInfoPtr_loader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022A2 RID: 8866
		// (get) Token: 0x06007265 RID: 29285 RVA: 0x001F45F8 File Offset: 0x001F27F8
		// (set) Token: 0x06007266 RID: 29286 RVA: 0x00036614 File Offset: 0x00034814
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BusinessManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BusinessManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022A3 RID: 8867
		// (get) Token: 0x06007267 RID: 29287 RVA: 0x001F4628 File Offset: 0x001F2828
		// (set) Token: 0x06007268 RID: 29288 RVA: 0x00036633 File Offset: 0x00034833
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BusinessManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BusinessManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022A4 RID: 8868
		// (get) Token: 0x06007269 RID: 29289 RVA: 0x001F4658 File Offset: 0x001F2858
		// (set) Token: 0x0600726A RID: 29290 RVA: 0x00036652 File Offset: 0x00034852
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BusinessManager.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BusinessManager.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x04004E05 RID: 19973
		private static readonly IntPtr NativeFieldInfoPtr_loader;

		// Token: 0x04004E06 RID: 19974
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x04004E07 RID: 19975
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x04004E08 RID: 19976
		private static readonly IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x04004E09 RID: 19977
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04004E0A RID: 19978
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04004E0B RID: 19979
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x04004E0C RID: 19980
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04004E0D RID: 19981
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04004E0E RID: 19982
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04004E0F RID: 19983
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04004E10 RID: 19984
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04004E11 RID: 19985
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04004E12 RID: 19986
		private static readonly IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04004E13 RID: 19987
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04004E14 RID: 19988
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x04004E15 RID: 19989
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x04004E16 RID: 19990
		private static readonly IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0;

		// Token: 0x04004E17 RID: 19991
		private static readonly IntPtr NativeMethodInfoPtr_LoadBusiness_Public_Void_BusinessData_String_0;

		// Token: 0x04004E18 RID: 19992
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A83 RID: 2691
		[ObfuscatedName("ScheduleOne.Property.BusinessManager+<>c__DisplayClass25_0")]
		public sealed class __c__DisplayClass25_0 : Object
		{
			// Token: 0x0600D201 RID: 53761 RVA: 0x00324150 File Offset: 0x00322350
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass25_0()
			{
				Il2CppClassPointerStore<BusinessManager.__c__DisplayClass25_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BusinessManager>.NativeClassPtr, "<>c__DisplayClass25_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BusinessManager.__c__DisplayClass25_0>.NativeClassPtr);
				BusinessManager.__c__DisplayClass25_0.NativeFieldInfoPtr_businessData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BusinessManager.__c__DisplayClass25_0>.NativeClassPtr, "businessData");
				BusinessManager.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BusinessManager.__c__DisplayClass25_0>.NativeClassPtr, 100677656);
				BusinessManager.__c__DisplayClass25_0.NativeMethodInfoPtr__LoadBusiness_b__0_Internal_Boolean_Business_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BusinessManager.__c__DisplayClass25_0>.NativeClassPtr, 100677657);
				BusinessManager.__c__DisplayClass25_0.NativeMethodInfoPtr__LoadBusiness_b__1_Internal_Boolean_Business_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BusinessManager.__c__DisplayClass25_0>.NativeClassPtr, 100677658);
			}

			// Token: 0x0600D202 RID: 53762 RVA: 0x003241CC File Offset: 0x003223CC
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass25_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BusinessManager.__c__DisplayClass25_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BusinessManager.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D203 RID: 53763 RVA: 0x00324208 File Offset: 0x00322408
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224160, XrefRangeEnd = 224162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _LoadBusiness_b__0(Business p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BusinessManager.__c__DisplayClass25_0.NativeMethodInfoPtr__LoadBusiness_b__0_Internal_Boolean_Business_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D204 RID: 53764 RVA: 0x00324258 File Offset: 0x00322458
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _LoadBusiness_b__1(Business p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BusinessManager.__c__DisplayClass25_0.NativeMethodInfoPtr__LoadBusiness_b__1_Internal_Boolean_Business_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D205 RID: 53765 RVA: 0x00066461 File Offset: 0x00064661
			public __c__DisplayClass25_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004131 RID: 16689
			// (get) Token: 0x0600D206 RID: 53766 RVA: 0x003242A8 File Offset: 0x003224A8
			// (set) Token: 0x0600D207 RID: 53767 RVA: 0x0006646A File Offset: 0x0006466A
			public unsafe BusinessData businessData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BusinessManager.__c__DisplayClass25_0.NativeFieldInfoPtr_businessData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BusinessData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BusinessManager.__c__DisplayClass25_0.NativeFieldInfoPtr_businessData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008DA9 RID: 36265
			private static readonly IntPtr NativeFieldInfoPtr_businessData;

			// Token: 0x04008DAA RID: 36266
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008DAB RID: 36267
			private static readonly IntPtr NativeMethodInfoPtr__LoadBusiness_b__0_Internal_Boolean_Business_0;

			// Token: 0x04008DAC RID: 36268
			private static readonly IntPtr NativeMethodInfoPtr__LoadBusiness_b__1_Internal_Boolean_Business_0;
		}
	}
}
