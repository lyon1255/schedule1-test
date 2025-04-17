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
	// Token: 0x02000511 RID: 1297
	public class PropertyManager : Singleton<PropertyManager>
	{
		// Token: 0x06007336 RID: 29494 RVA: 0x001F71AC File Offset: 0x001F53AC
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyManager()
		{
			Il2CppClassPointerStore<PropertyManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Property", "PropertyManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyManager>.NativeClassPtr);
			PropertyManager.NativeFieldInfoPtr_loader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyManager>.NativeClassPtr, "loader");
			PropertyManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyManager>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			PropertyManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyManager>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			PropertyManager.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyManager>.NativeClassPtr, "<HasChanged>k__BackingField");
			PropertyManager.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyManager>.NativeClassPtr, 100677761);
			PropertyManager.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyManager>.NativeClassPtr, 100677762);
			PropertyManager.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyManager>.NativeClassPtr, 100677763);
			PropertyManager.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyManager>.NativeClassPtr, 100677764);
			PropertyManager.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyManager>.NativeClassPtr, 100677765);
			PropertyManager.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyManager>.NativeClassPtr, 100677766);
			PropertyManager.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyManager>.NativeClassPtr, 100677767);
			PropertyManager.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyManager>.NativeClassPtr, 100677768);
			PropertyManager.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyManager>.NativeClassPtr, 100677769);
			PropertyManager.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyManager>.NativeClassPtr, 100677770);
			PropertyManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyManager>.NativeClassPtr, 100677771);
			PropertyManager.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyManager>.NativeClassPtr, 100677772);
			PropertyManager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyManager>.NativeClassPtr, 100677773);
			PropertyManager.NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyManager>.NativeClassPtr, 100677774);
			PropertyManager.NativeMethodInfoPtr_LoadProperty_Public_Void_PropertyData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyManager>.NativeClassPtr, 100677775);
			PropertyManager.NativeMethodInfoPtr_GetProperty_Public_Property_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyManager>.NativeClassPtr, 100677776);
			PropertyManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyManager>.NativeClassPtr, 100677777);
		}

		// Token: 0x170022F5 RID: 8949
		// (get) Token: 0x06007337 RID: 29495 RVA: 0x001F7380 File Offset: 0x001F5580
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225414, XrefRangeEnd = 225416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyManager.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170022F6 RID: 8950
		// (get) Token: 0x06007338 RID: 29496 RVA: 0x001F73B8 File Offset: 0x001F55B8
		public unsafe virtual string SaveFileName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225416, XrefRangeEnd = 225418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyManager.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170022F7 RID: 8951
		// (get) Token: 0x06007339 RID: 29497 RVA: 0x001F73F0 File Offset: 0x001F55F0
		public unsafe virtual Loader Loader
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19639, RefRangeEnd = 19642, XrefRangeStart = 19639, XrefRangeEnd = 19642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyManager.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr3) : null;
			}
		}

		// Token: 0x170022F8 RID: 8952
		// (get) Token: 0x0600733A RID: 29498 RVA: 0x001F7430 File Offset: 0x001F5630
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 30137, RefRangeEnd = 30157, XrefRangeStart = 30137, XrefRangeEnd = 30157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyManager.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170022F9 RID: 8953
		// (get) Token: 0x0600733B RID: 29499 RVA: 0x001F746C File Offset: 0x001F566C
		// (set) Token: 0x0600733C RID: 29500 RVA: 0x001F74AC File Offset: 0x001F56AC
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 19646, RefRangeEnd = 19660, XrefRangeStart = 19646, XrefRangeEnd = 19660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyManager.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyManager.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170022FA RID: 8954
		// (get) Token: 0x0600733D RID: 29501 RVA: 0x001F74F0 File Offset: 0x001F56F0
		// (set) Token: 0x0600733E RID: 29502 RVA: 0x001F7530 File Offset: 0x001F5730
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 19662, RefRangeEnd = 19669, XrefRangeStart = 19662, XrefRangeEnd = 19669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyManager.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyManager.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170022FB RID: 8955
		// (get) Token: 0x0600733F RID: 29503 RVA: 0x001F7574 File Offset: 0x001F5774
		// (set) Token: 0x06007340 RID: 29504 RVA: 0x001F75B0 File Offset: 0x001F57B0
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyManager.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyManager.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007341 RID: 29505 RVA: 0x001F75F0 File Offset: 0x001F57F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225418, XrefRangeEnd = 225421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007342 RID: 29506 RVA: 0x001F762C File Offset: 0x001F582C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225421, XrefRangeEnd = 225427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyManager.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007343 RID: 29507 RVA: 0x001F7668 File Offset: 0x001F5868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225427, XrefRangeEnd = 225429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyManager.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06007344 RID: 29508 RVA: 0x001F76AC File Offset: 0x001F58AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225429, XrefRangeEnd = 225515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<string> WriteData(string parentFolderPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(parentFolderPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertyManager.NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x06007345 RID: 29509 RVA: 0x001F7708 File Offset: 0x001F5908
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 225587, RefRangeEnd = 225588, XrefRangeStart = 225515, XrefRangeEnd = 225587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadProperty(PropertyData propertyData, string containerPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(propertyData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(containerPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyManager.NativeMethodInfoPtr_LoadProperty_Public_Void_PropertyData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007346 RID: 29510 RVA: 0x001F775C File Offset: 0x001F595C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 225620, RefRangeEnd = 225623, XrefRangeStart = 225588, XrefRangeEnd = 225620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Property GetProperty(string code)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(code);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyManager.NativeMethodInfoPtr_GetProperty_Public_Property_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Property>(intPtr3) : null;
		}

		// Token: 0x06007347 RID: 29511 RVA: 0x001F77AC File Offset: 0x001F59AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225623, XrefRangeEnd = 225643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007348 RID: 29512 RVA: 0x00036CC7 File Offset: 0x00034EC7
		public PropertyManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170022F1 RID: 8945
		// (get) Token: 0x06007349 RID: 29513 RVA: 0x001F77E8 File Offset: 0x001F59E8
		// (set) Token: 0x0600734A RID: 29514 RVA: 0x00036CD0 File Offset: 0x00034ED0
		public unsafe PropertiesLoader loader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyManager.NativeFieldInfoPtr_loader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertiesLoader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyManager.NativeFieldInfoPtr_loader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022F2 RID: 8946
		// (get) Token: 0x0600734B RID: 29515 RVA: 0x001F7818 File Offset: 0x001F5A18
		// (set) Token: 0x0600734C RID: 29516 RVA: 0x00036CEF File Offset: 0x00034EEF
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyManager.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022F3 RID: 8947
		// (get) Token: 0x0600734D RID: 29517 RVA: 0x001F7848 File Offset: 0x001F5A48
		// (set) Token: 0x0600734E RID: 29518 RVA: 0x00036D0E File Offset: 0x00034F0E
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyManager.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170022F4 RID: 8948
		// (get) Token: 0x0600734F RID: 29519 RVA: 0x001F7878 File Offset: 0x001F5A78
		// (set) Token: 0x06007350 RID: 29520 RVA: 0x00036D2D File Offset: 0x00034F2D
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyManager.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyManager.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x04004EA3 RID: 20131
		private static readonly IntPtr NativeFieldInfoPtr_loader;

		// Token: 0x04004EA4 RID: 20132
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x04004EA5 RID: 20133
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x04004EA6 RID: 20134
		private static readonly IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x04004EA7 RID: 20135
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04004EA8 RID: 20136
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04004EA9 RID: 20137
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x04004EAA RID: 20138
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04004EAB RID: 20139
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04004EAC RID: 20140
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04004EAD RID: 20141
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04004EAE RID: 20142
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04004EAF RID: 20143
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04004EB0 RID: 20144
		private static readonly IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04004EB1 RID: 20145
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04004EB2 RID: 20146
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x04004EB3 RID: 20147
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x04004EB4 RID: 20148
		private static readonly IntPtr NativeMethodInfoPtr_WriteData_Public_Virtual_New_List_1_String_String_0;

		// Token: 0x04004EB5 RID: 20149
		private static readonly IntPtr NativeMethodInfoPtr_LoadProperty_Public_Void_PropertyData_String_0;

		// Token: 0x04004EB6 RID: 20150
		private static readonly IntPtr NativeMethodInfoPtr_GetProperty_Public_Property_String_0;

		// Token: 0x04004EB7 RID: 20151
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A89 RID: 2697
		[ObfuscatedName("ScheduleOne.Property.PropertyManager+<>c__DisplayClass25_0")]
		public sealed class __c__DisplayClass25_0 : Object
		{
			// Token: 0x0600D237 RID: 53815 RVA: 0x00324B74 File Offset: 0x00322D74
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass25_0()
			{
				Il2CppClassPointerStore<PropertyManager.__c__DisplayClass25_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PropertyManager>.NativeClassPtr, "<>c__DisplayClass25_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyManager.__c__DisplayClass25_0>.NativeClassPtr);
				PropertyManager.__c__DisplayClass25_0.NativeFieldInfoPtr_propertyData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyManager.__c__DisplayClass25_0>.NativeClassPtr, "propertyData");
				PropertyManager.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyManager.__c__DisplayClass25_0>.NativeClassPtr, 100677778);
				PropertyManager.__c__DisplayClass25_0.NativeMethodInfoPtr__LoadProperty_b__0_Internal_Boolean_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyManager.__c__DisplayClass25_0>.NativeClassPtr, 100677779);
				PropertyManager.__c__DisplayClass25_0.NativeMethodInfoPtr__LoadProperty_b__1_Internal_Boolean_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyManager.__c__DisplayClass25_0>.NativeClassPtr, 100677780);
				PropertyManager.__c__DisplayClass25_0.NativeMethodInfoPtr__LoadProperty_b__2_Internal_Boolean_Business_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyManager.__c__DisplayClass25_0>.NativeClassPtr, 100677781);
				PropertyManager.__c__DisplayClass25_0.NativeMethodInfoPtr__LoadProperty_b__3_Internal_Boolean_Business_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyManager.__c__DisplayClass25_0>.NativeClassPtr, 100677782);
			}

			// Token: 0x0600D238 RID: 53816 RVA: 0x00324C18 File Offset: 0x00322E18
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass25_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyManager.__c__DisplayClass25_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyManager.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D239 RID: 53817 RVA: 0x00324C54 File Offset: 0x00322E54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _LoadProperty_b__0(Property p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyManager.__c__DisplayClass25_0.NativeMethodInfoPtr__LoadProperty_b__0_Internal_Boolean_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D23A RID: 53818 RVA: 0x00324CA4 File Offset: 0x00322EA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _LoadProperty_b__1(Property p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyManager.__c__DisplayClass25_0.NativeMethodInfoPtr__LoadProperty_b__1_Internal_Boolean_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D23B RID: 53819 RVA: 0x00324CF4 File Offset: 0x00322EF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _LoadProperty_b__2(Business p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyManager.__c__DisplayClass25_0.NativeMethodInfoPtr__LoadProperty_b__2_Internal_Boolean_Business_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D23C RID: 53820 RVA: 0x00324D44 File Offset: 0x00322F44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _LoadProperty_b__3(Business p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyManager.__c__DisplayClass25_0.NativeMethodInfoPtr__LoadProperty_b__3_Internal_Boolean_Business_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D23D RID: 53821 RVA: 0x000665BC File Offset: 0x000647BC
			public __c__DisplayClass25_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700413D RID: 16701
			// (get) Token: 0x0600D23E RID: 53822 RVA: 0x00324D94 File Offset: 0x00322F94
			// (set) Token: 0x0600D23F RID: 53823 RVA: 0x000665C5 File Offset: 0x000647C5
			public unsafe PropertyData propertyData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyManager.__c__DisplayClass25_0.NativeFieldInfoPtr_propertyData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertyData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyManager.__c__DisplayClass25_0.NativeFieldInfoPtr_propertyData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008DC6 RID: 36294
			private static readonly IntPtr NativeFieldInfoPtr_propertyData;

			// Token: 0x04008DC7 RID: 36295
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008DC8 RID: 36296
			private static readonly IntPtr NativeMethodInfoPtr__LoadProperty_b__0_Internal_Boolean_Property_0;

			// Token: 0x04008DC9 RID: 36297
			private static readonly IntPtr NativeMethodInfoPtr__LoadProperty_b__1_Internal_Boolean_Property_0;

			// Token: 0x04008DCA RID: 36298
			private static readonly IntPtr NativeMethodInfoPtr__LoadProperty_b__2_Internal_Boolean_Business_0;

			// Token: 0x04008DCB RID: 36299
			private static readonly IntPtr NativeMethodInfoPtr__LoadProperty_b__3_Internal_Boolean_Business_0;
		}

		// Token: 0x02000A8A RID: 2698
		[ObfuscatedName("ScheduleOne.Property.PropertyManager+<>c__DisplayClass26_0")]
		public sealed class __c__DisplayClass26_0 : Object
		{
			// Token: 0x0600D240 RID: 53824 RVA: 0x00324DC4 File Offset: 0x00322FC4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass26_0()
			{
				Il2CppClassPointerStore<PropertyManager.__c__DisplayClass26_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PropertyManager>.NativeClassPtr, "<>c__DisplayClass26_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyManager.__c__DisplayClass26_0>.NativeClassPtr);
				PropertyManager.__c__DisplayClass26_0.NativeFieldInfoPtr_code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyManager.__c__DisplayClass26_0>.NativeClassPtr, "code");
				PropertyManager.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyManager.__c__DisplayClass26_0>.NativeClassPtr, 100677783);
				PropertyManager.__c__DisplayClass26_0.NativeMethodInfoPtr__GetProperty_b__0_Internal_Boolean_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyManager.__c__DisplayClass26_0>.NativeClassPtr, 100677784);
				PropertyManager.__c__DisplayClass26_0.NativeMethodInfoPtr__GetProperty_b__1_Internal_Boolean_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyManager.__c__DisplayClass26_0>.NativeClassPtr, 100677785);
			}

			// Token: 0x0600D241 RID: 53825 RVA: 0x00324E40 File Offset: 0x00323040
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass26_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyManager.__c__DisplayClass26_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyManager.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D242 RID: 53826 RVA: 0x00324E7C File Offset: 0x0032307C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetProperty_b__0(Property p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyManager.__c__DisplayClass26_0.NativeMethodInfoPtr__GetProperty_b__0_Internal_Boolean_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D243 RID: 53827 RVA: 0x00324ECC File Offset: 0x003230CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetProperty_b__1(Property p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyManager.__c__DisplayClass26_0.NativeMethodInfoPtr__GetProperty_b__1_Internal_Boolean_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D244 RID: 53828 RVA: 0x000665E4 File Offset: 0x000647E4
			public __c__DisplayClass26_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700413E RID: 16702
			// (get) Token: 0x0600D245 RID: 53829 RVA: 0x00324F1C File Offset: 0x0032311C
			// (set) Token: 0x0600D246 RID: 53830 RVA: 0x000665ED File Offset: 0x000647ED
			public unsafe string code
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyManager.__c__DisplayClass26_0.NativeFieldInfoPtr_code);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyManager.__c__DisplayClass26_0.NativeFieldInfoPtr_code), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008DCC RID: 36300
			private static readonly IntPtr NativeFieldInfoPtr_code;

			// Token: 0x04008DCD RID: 36301
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008DCE RID: 36302
			private static readonly IntPtr NativeMethodInfoPtr__GetProperty_b__0_Internal_Boolean_Property_0;

			// Token: 0x04008DCF RID: 36303
			private static readonly IntPtr NativeMethodInfoPtr__GetProperty_b__1_Internal_Boolean_Property_0;
		}
	}
}
