using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Property;
using Il2CppScheduleOne.Quests;
using Il2CppScheduleOne.VoiceOver;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Employees
{
	// Token: 0x02000409 RID: 1033
	public class EmployeeManager : NetworkSingleton<EmployeeManager>
	{
		// Token: 0x0600581C RID: 22556 RVA: 0x0019AF00 File Offset: 0x00199100
		// Note: this type is marked as 'beforefieldinit'.
		static EmployeeManager()
		{
			Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Employees", "EmployeeManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr);
			EmployeeManager.NativeFieldInfoPtr_MALE_EMPLOYEE_CHANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "MALE_EMPLOYEE_CHANCE");
			EmployeeManager.NativeFieldInfoPtr_AllEmployees = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "AllEmployees");
			EmployeeManager.NativeFieldInfoPtr_EmployeeQuests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "EmployeeQuests");
			EmployeeManager.NativeFieldInfoPtr_BotanistPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "BotanistPrefab");
			EmployeeManager.NativeFieldInfoPtr_PackagerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "PackagerPrefab");
			EmployeeManager.NativeFieldInfoPtr_ChemistPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "ChemistPrefab");
			EmployeeManager.NativeFieldInfoPtr_CleanerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "CleanerPrefab");
			EmployeeManager.NativeFieldInfoPtr_MaleAppearances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "MaleAppearances");
			EmployeeManager.NativeFieldInfoPtr_FemaleAppearances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "FemaleAppearances");
			EmployeeManager.NativeFieldInfoPtr_MaleVoices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "MaleVoices");
			EmployeeManager.NativeFieldInfoPtr_FemaleVoices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "FemaleVoices");
			EmployeeManager.NativeFieldInfoPtr_MaleFirstNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "MaleFirstNames");
			EmployeeManager.NativeFieldInfoPtr_FemaleFirstNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "FemaleFirstNames");
			EmployeeManager.NativeFieldInfoPtr_LastNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "LastNames");
			EmployeeManager.NativeFieldInfoPtr_takenNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "takenNames");
			EmployeeManager.NativeFieldInfoPtr_takenMaleAppearances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "takenMaleAppearances");
			EmployeeManager.NativeFieldInfoPtr_takenFemaleAppearances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "takenFemaleAppearances");
			EmployeeManager.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Employees.EmployeeManagerAssembly-CSharp.dll_Excuted");
			EmployeeManager.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Employees.EmployeeManagerAssembly-CSharp.dll_Excuted");
			EmployeeManager.NativeMethodInfoPtr_CreateNewEmployee_Public_Void_Property_EEmployeeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100674416);
			EmployeeManager.NativeMethodInfoPtr_CreateEmployee_Public_Void_Property_EEmployeeType_String_String_String_Boolean_Int32_Vector3_Quaternion_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100674417);
			EmployeeManager.NativeMethodInfoPtr_CreateEmployee_Server_Public_Employee_Property_EEmployeeType_String_String_String_Boolean_Int32_Vector3_Quaternion_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100674418);
			EmployeeManager.NativeMethodInfoPtr_IsPositionValid_Private_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100674419);
			EmployeeManager.NativeMethodInfoPtr_IsRotationValid_Private_Boolean_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100674420);
			EmployeeManager.NativeMethodInfoPtr_IsFloatValid_Private_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100674421);
			EmployeeManager.NativeMethodInfoPtr_RegisterName_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100674422);
			EmployeeManager.NativeMethodInfoPtr_RegisterAppearance_Public_Void_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100674423);
			EmployeeManager.NativeMethodInfoPtr_GenerateRandomName_Public_Void_Boolean_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100674424);
			EmployeeManager.NativeMethodInfoPtr_GetAppearance_Public_EmployeeAppearance_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100674425);
			EmployeeManager.NativeMethodInfoPtr_GetVoice_Public_VODatabase_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100674426);
			EmployeeManager.NativeMethodInfoPtr_GetRandomAppearance_Public_Void_Boolean_byref_Int32_byref_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100674427);
			EmployeeManager.NativeMethodInfoPtr_GetEmployeePrefab_Public_Employee_EEmployeeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100674428);
			EmployeeManager.NativeMethodInfoPtr_GetEmployeesByType_Public_List_1_Employee_EEmployeeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100674429);
			EmployeeManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100674430);
			EmployeeManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100674431);
			EmployeeManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100674432);
			EmployeeManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100674433);
			EmployeeManager.NativeMethodInfoPtr_RpcWriter___Server_CreateEmployee_311954683_Private_Void_Property_EEmployeeType_String_String_String_Boolean_Int32_Vector3_Quaternion_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100674434);
			EmployeeManager.NativeMethodInfoPtr_RpcLogic___CreateEmployee_311954683_Public_Void_Property_EEmployeeType_String_String_String_Boolean_Int32_Vector3_Quaternion_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100674435);
			EmployeeManager.NativeMethodInfoPtr_RpcReader___Server_CreateEmployee_311954683_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100674436);
			EmployeeManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, 100674437);
		}

		// Token: 0x0600581D RID: 22557 RVA: 0x0019B264 File Offset: 0x00199464
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 185714, RefRangeEnd = 185715, XrefRangeStart = 185669, XrefRangeEnd = 185714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateNewEmployee(Property property, EEmployeeType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_CreateNewEmployee_Public_Void_Property_EEmployeeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600581E RID: 22558 RVA: 0x0019B2B4 File Offset: 0x001994B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185715, XrefRangeEnd = 185716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateEmployee(Property property, EEmployeeType type, string firstName, string lastName, string id, bool male, int appearanceIndex, Vector3 position, Quaternion rotation, string guid = "")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(firstName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lastName);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref male;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref appearanceIndex;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_CreateEmployee_Public_Void_Property_EEmployeeType_String_String_String_Boolean_Int32_Vector3_Quaternion_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600581F RID: 22559 RVA: 0x0019B38C File Offset: 0x0019958C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 185775, RefRangeEnd = 185778, XrefRangeStart = 185716, XrefRangeEnd = 185775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Employee CreateEmployee_Server(Property property, EEmployeeType type, string firstName, string lastName, string id, bool male, int appearanceIndex, Vector3 position, Quaternion rotation, string guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(firstName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lastName);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref male;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref appearanceIndex;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_CreateEmployee_Server_Public_Employee_Property_EEmployeeType_String_String_String_Boolean_Int32_Vector3_Quaternion_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Employee>(intPtr3) : null;
		}

		// Token: 0x06005820 RID: 22560 RVA: 0x0019B470 File Offset: 0x00199670
		[CallerCount(0)]
		public unsafe bool IsPositionValid(Vector3 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_IsPositionValid_Private_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005821 RID: 22561 RVA: 0x0019B4BC File Offset: 0x001996BC
		[CallerCount(0)]
		public unsafe bool IsRotationValid(Quaternion rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_IsRotationValid_Private_Boolean_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005822 RID: 22562 RVA: 0x0019B508 File Offset: 0x00199708
		[CallerCount(0)]
		public unsafe bool IsFloatValid(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_IsFloatValid_Private_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005823 RID: 22563 RVA: 0x0019B554 File Offset: 0x00199754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185778, XrefRangeEnd = 185784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterName(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_RegisterName_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005824 RID: 22564 RVA: 0x0019B598 File Offset: 0x00199798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185784, XrefRangeEnd = 185787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterAppearance(bool male, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref male;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_RegisterAppearance_Public_Void_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005825 RID: 22565 RVA: 0x0019B5E4 File Offset: 0x001997E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 185798, RefRangeEnd = 185799, XrefRangeStart = 185787, XrefRangeEnd = 185798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateRandomName(bool male, out string firstName, out string lastName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref male;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_GenerateRandomName_Public_Void_Boolean_byref_String_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			firstName = IL2CPP.Il2CppStringToManaged(intPtr);
			lastName = IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x06005826 RID: 22566 RVA: 0x0019B658 File Offset: 0x00199858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185799, XrefRangeEnd = 185804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EmployeeManager.EmployeeAppearance GetAppearance(bool male, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref male;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_GetAppearance_Public_EmployeeAppearance_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EmployeeManager.EmployeeAppearance>(intPtr3) : null;
		}

		// Token: 0x06005827 RID: 22567 RVA: 0x0019B6B4 File Offset: 0x001998B4
		[CallerCount(0)]
		public unsafe VODatabase GetVoice(bool male, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref male;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_GetVoice_Public_VODatabase_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VODatabase>(intPtr3) : null;
		}

		// Token: 0x06005828 RID: 22568 RVA: 0x0019B710 File Offset: 0x00199910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185804, XrefRangeEnd = 185818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetRandomAppearance(bool male, out int index, out AvatarSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref male;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &index;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_GetRandomAppearance_Public_Void_Boolean_byref_Int32_byref_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			settings = ((intPtr4 == 0) ? null : new AvatarSettings(intPtr4));
		}

		// Token: 0x06005829 RID: 22569 RVA: 0x0019B780 File Offset: 0x00199980
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 185828, RefRangeEnd = 185831, XrefRangeStart = 185818, XrefRangeEnd = 185828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Employee GetEmployeePrefab(EEmployeeType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_GetEmployeePrefab_Public_Employee_EEmployeeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Employee>(intPtr3) : null;
		}

		// Token: 0x0600582A RID: 22570 RVA: 0x0019B7CC File Offset: 0x001999CC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 185854, RefRangeEnd = 185858, XrefRangeStart = 185831, XrefRangeEnd = 185854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Employee> GetEmployeesByType(EEmployeeType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_GetEmployeesByType_Public_List_1_Employee_EEmployeeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Employee>>(intPtr3) : null;
		}

		// Token: 0x0600582B RID: 22571 RVA: 0x0019B818 File Offset: 0x00199A18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185858, XrefRangeEnd = 185887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EmployeeManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600582C RID: 22572 RVA: 0x0019B854 File Offset: 0x00199A54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185887, XrefRangeEnd = 185897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EmployeeManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600582D RID: 22573 RVA: 0x0019B890 File Offset: 0x00199A90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185897, XrefRangeEnd = 185900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EmployeeManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600582E RID: 22574 RVA: 0x0019B8CC File Offset: 0x00199ACC
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EmployeeManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600582F RID: 22575 RVA: 0x0019B908 File Offset: 0x00199B08
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 185933, RefRangeEnd = 185935, XrefRangeStart = 185900, XrefRangeEnd = 185933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_CreateEmployee_311954683(Property property, EEmployeeType type, string firstName, string lastName, string id, bool male, int appearanceIndex, Vector3 position, Quaternion rotation, string guid = "")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(firstName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lastName);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref male;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref appearanceIndex;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_RpcWriter___Server_CreateEmployee_311954683_Private_Void_Property_EEmployeeType_String_String_String_Boolean_Int32_Vector3_Quaternion_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005830 RID: 22576 RVA: 0x0019B9E0 File Offset: 0x00199BE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185935, XrefRangeEnd = 185936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___CreateEmployee_311954683(Property property, EEmployeeType type, string firstName, string lastName, string id, bool male, int appearanceIndex, Vector3 position, Quaternion rotation, string guid = "")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(firstName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lastName);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref male;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref appearanceIndex;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(guid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_RpcLogic___CreateEmployee_311954683_Public_Void_Property_EEmployeeType_String_String_String_Boolean_Int32_Vector3_Quaternion_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005831 RID: 22577 RVA: 0x0019BAB8 File Offset: 0x00199CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185936, XrefRangeEnd = 185951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_CreateEmployee_311954683(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.NativeMethodInfoPtr_RpcReader___Server_CreateEmployee_311954683_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005832 RID: 22578 RVA: 0x0019BB1C File Offset: 0x00199D1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185951, XrefRangeEnd = 185954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EmployeeManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005833 RID: 22579 RVA: 0x00029E4A File Offset: 0x0002804A
		public EmployeeManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001A9A RID: 6810
		// (get) Token: 0x06005834 RID: 22580 RVA: 0x0019BB58 File Offset: 0x00199D58
		// (set) Token: 0x06005835 RID: 22581 RVA: 0x00029E53 File Offset: 0x00028053
		public unsafe static float MALE_EMPLOYEE_CHANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(EmployeeManager.NativeFieldInfoPtr_MALE_EMPLOYEE_CHANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EmployeeManager.NativeFieldInfoPtr_MALE_EMPLOYEE_CHANCE, (void*)(&value));
			}
		}

		// Token: 0x17001A9B RID: 6811
		// (get) Token: 0x06005836 RID: 22582 RVA: 0x0019BB74 File Offset: 0x00199D74
		// (set) Token: 0x06005837 RID: 22583 RVA: 0x00029E61 File Offset: 0x00028061
		public unsafe List<Employee> AllEmployees
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_AllEmployees);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Employee>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_AllEmployees), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A9C RID: 6812
		// (get) Token: 0x06005838 RID: 22584 RVA: 0x0019BBA4 File Offset: 0x00199DA4
		// (set) Token: 0x06005839 RID: 22585 RVA: 0x00029E80 File Offset: 0x00028080
		public unsafe Il2CppReferenceArray<Quest_Employees> EmployeeQuests
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_EmployeeQuests);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Quest_Employees>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_EmployeeQuests), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A9D RID: 6813
		// (get) Token: 0x0600583A RID: 22586 RVA: 0x0019BBD4 File Offset: 0x00199DD4
		// (set) Token: 0x0600583B RID: 22587 RVA: 0x00029E9F File Offset: 0x0002809F
		public unsafe Botanist BotanistPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_BotanistPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Botanist>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_BotanistPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A9E RID: 6814
		// (get) Token: 0x0600583C RID: 22588 RVA: 0x0019BC04 File Offset: 0x00199E04
		// (set) Token: 0x0600583D RID: 22589 RVA: 0x00029EBE File Offset: 0x000280BE
		public unsafe Packager PackagerPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_PackagerPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Packager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_PackagerPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A9F RID: 6815
		// (get) Token: 0x0600583E RID: 22590 RVA: 0x0019BC34 File Offset: 0x00199E34
		// (set) Token: 0x0600583F RID: 22591 RVA: 0x00029EDD File Offset: 0x000280DD
		public unsafe Chemist ChemistPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_ChemistPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Chemist>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_ChemistPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AA0 RID: 6816
		// (get) Token: 0x06005840 RID: 22592 RVA: 0x0019BC64 File Offset: 0x00199E64
		// (set) Token: 0x06005841 RID: 22593 RVA: 0x00029EFC File Offset: 0x000280FC
		public unsafe Cleaner CleanerPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_CleanerPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cleaner>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_CleanerPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AA1 RID: 6817
		// (get) Token: 0x06005842 RID: 22594 RVA: 0x0019BC94 File Offset: 0x00199E94
		// (set) Token: 0x06005843 RID: 22595 RVA: 0x00029F1B File Offset: 0x0002811B
		public unsafe List<EmployeeManager.EmployeeAppearance> MaleAppearances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_MaleAppearances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EmployeeManager.EmployeeAppearance>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_MaleAppearances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AA2 RID: 6818
		// (get) Token: 0x06005844 RID: 22596 RVA: 0x0019BCC4 File Offset: 0x00199EC4
		// (set) Token: 0x06005845 RID: 22597 RVA: 0x00029F3A File Offset: 0x0002813A
		public unsafe List<EmployeeManager.EmployeeAppearance> FemaleAppearances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_FemaleAppearances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EmployeeManager.EmployeeAppearance>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_FemaleAppearances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AA3 RID: 6819
		// (get) Token: 0x06005846 RID: 22598 RVA: 0x0019BCF4 File Offset: 0x00199EF4
		// (set) Token: 0x06005847 RID: 22599 RVA: 0x00029F59 File Offset: 0x00028159
		public unsafe Il2CppReferenceArray<VODatabase> MaleVoices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_MaleVoices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<VODatabase>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_MaleVoices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AA4 RID: 6820
		// (get) Token: 0x06005848 RID: 22600 RVA: 0x0019BD24 File Offset: 0x00199F24
		// (set) Token: 0x06005849 RID: 22601 RVA: 0x00029F78 File Offset: 0x00028178
		public unsafe Il2CppReferenceArray<VODatabase> FemaleVoices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_FemaleVoices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<VODatabase>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_FemaleVoices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AA5 RID: 6821
		// (get) Token: 0x0600584A RID: 22602 RVA: 0x0019BD54 File Offset: 0x00199F54
		// (set) Token: 0x0600584B RID: 22603 RVA: 0x00029F97 File Offset: 0x00028197
		public unsafe Il2CppStringArray MaleFirstNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_MaleFirstNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_MaleFirstNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AA6 RID: 6822
		// (get) Token: 0x0600584C RID: 22604 RVA: 0x0019BD84 File Offset: 0x00199F84
		// (set) Token: 0x0600584D RID: 22605 RVA: 0x00029FB6 File Offset: 0x000281B6
		public unsafe Il2CppStringArray FemaleFirstNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_FemaleFirstNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_FemaleFirstNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AA7 RID: 6823
		// (get) Token: 0x0600584E RID: 22606 RVA: 0x0019BDB4 File Offset: 0x00199FB4
		// (set) Token: 0x0600584F RID: 22607 RVA: 0x00029FD5 File Offset: 0x000281D5
		public unsafe Il2CppStringArray LastNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_LastNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_LastNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AA8 RID: 6824
		// (get) Token: 0x06005850 RID: 22608 RVA: 0x0019BDE4 File Offset: 0x00199FE4
		// (set) Token: 0x06005851 RID: 22609 RVA: 0x00029FF4 File Offset: 0x000281F4
		public unsafe List<string> takenNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_takenNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_takenNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AA9 RID: 6825
		// (get) Token: 0x06005852 RID: 22610 RVA: 0x0019BE14 File Offset: 0x0019A014
		// (set) Token: 0x06005853 RID: 22611 RVA: 0x0002A013 File Offset: 0x00028213
		public unsafe List<int> takenMaleAppearances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_takenMaleAppearances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_takenMaleAppearances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AAA RID: 6826
		// (get) Token: 0x06005854 RID: 22612 RVA: 0x0019BE44 File Offset: 0x0019A044
		// (set) Token: 0x06005855 RID: 22613 RVA: 0x0002A032 File Offset: 0x00028232
		public unsafe List<int> takenFemaleAppearances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_takenFemaleAppearances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_takenFemaleAppearances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AAB RID: 6827
		// (get) Token: 0x06005856 RID: 22614 RVA: 0x0019BE74 File Offset: 0x0019A074
		// (set) Token: 0x06005857 RID: 22615 RVA: 0x0002A051 File Offset: 0x00028251
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001AAC RID: 6828
		// (get) Token: 0x06005858 RID: 22616 RVA: 0x0019BE9C File Offset: 0x0019A09C
		// (set) Token: 0x06005859 RID: 22617 RVA: 0x0002A06C File Offset: 0x0002826C
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04003BFA RID: 15354
		private static readonly IntPtr NativeFieldInfoPtr_MALE_EMPLOYEE_CHANCE;

		// Token: 0x04003BFB RID: 15355
		private static readonly IntPtr NativeFieldInfoPtr_AllEmployees;

		// Token: 0x04003BFC RID: 15356
		private static readonly IntPtr NativeFieldInfoPtr_EmployeeQuests;

		// Token: 0x04003BFD RID: 15357
		private static readonly IntPtr NativeFieldInfoPtr_BotanistPrefab;

		// Token: 0x04003BFE RID: 15358
		private static readonly IntPtr NativeFieldInfoPtr_PackagerPrefab;

		// Token: 0x04003BFF RID: 15359
		private static readonly IntPtr NativeFieldInfoPtr_ChemistPrefab;

		// Token: 0x04003C00 RID: 15360
		private static readonly IntPtr NativeFieldInfoPtr_CleanerPrefab;

		// Token: 0x04003C01 RID: 15361
		private static readonly IntPtr NativeFieldInfoPtr_MaleAppearances;

		// Token: 0x04003C02 RID: 15362
		private static readonly IntPtr NativeFieldInfoPtr_FemaleAppearances;

		// Token: 0x04003C03 RID: 15363
		private static readonly IntPtr NativeFieldInfoPtr_MaleVoices;

		// Token: 0x04003C04 RID: 15364
		private static readonly IntPtr NativeFieldInfoPtr_FemaleVoices;

		// Token: 0x04003C05 RID: 15365
		private static readonly IntPtr NativeFieldInfoPtr_MaleFirstNames;

		// Token: 0x04003C06 RID: 15366
		private static readonly IntPtr NativeFieldInfoPtr_FemaleFirstNames;

		// Token: 0x04003C07 RID: 15367
		private static readonly IntPtr NativeFieldInfoPtr_LastNames;

		// Token: 0x04003C08 RID: 15368
		private static readonly IntPtr NativeFieldInfoPtr_takenNames;

		// Token: 0x04003C09 RID: 15369
		private static readonly IntPtr NativeFieldInfoPtr_takenMaleAppearances;

		// Token: 0x04003C0A RID: 15370
		private static readonly IntPtr NativeFieldInfoPtr_takenFemaleAppearances;

		// Token: 0x04003C0B RID: 15371
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04003C0C RID: 15372
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04003C0D RID: 15373
		private static readonly IntPtr NativeMethodInfoPtr_CreateNewEmployee_Public_Void_Property_EEmployeeType_0;

		// Token: 0x04003C0E RID: 15374
		private static readonly IntPtr NativeMethodInfoPtr_CreateEmployee_Public_Void_Property_EEmployeeType_String_String_String_Boolean_Int32_Vector3_Quaternion_String_0;

		// Token: 0x04003C0F RID: 15375
		private static readonly IntPtr NativeMethodInfoPtr_CreateEmployee_Server_Public_Employee_Property_EEmployeeType_String_String_String_Boolean_Int32_Vector3_Quaternion_String_0;

		// Token: 0x04003C10 RID: 15376
		private static readonly IntPtr NativeMethodInfoPtr_IsPositionValid_Private_Boolean_Vector3_0;

		// Token: 0x04003C11 RID: 15377
		private static readonly IntPtr NativeMethodInfoPtr_IsRotationValid_Private_Boolean_Quaternion_0;

		// Token: 0x04003C12 RID: 15378
		private static readonly IntPtr NativeMethodInfoPtr_IsFloatValid_Private_Boolean_Single_0;

		// Token: 0x04003C13 RID: 15379
		private static readonly IntPtr NativeMethodInfoPtr_RegisterName_Public_Void_String_0;

		// Token: 0x04003C14 RID: 15380
		private static readonly IntPtr NativeMethodInfoPtr_RegisterAppearance_Public_Void_Boolean_Int32_0;

		// Token: 0x04003C15 RID: 15381
		private static readonly IntPtr NativeMethodInfoPtr_GenerateRandomName_Public_Void_Boolean_byref_String_byref_String_0;

		// Token: 0x04003C16 RID: 15382
		private static readonly IntPtr NativeMethodInfoPtr_GetAppearance_Public_EmployeeAppearance_Boolean_Int32_0;

		// Token: 0x04003C17 RID: 15383
		private static readonly IntPtr NativeMethodInfoPtr_GetVoice_Public_VODatabase_Boolean_Int32_0;

		// Token: 0x04003C18 RID: 15384
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomAppearance_Public_Void_Boolean_byref_Int32_byref_AvatarSettings_0;

		// Token: 0x04003C19 RID: 15385
		private static readonly IntPtr NativeMethodInfoPtr_GetEmployeePrefab_Public_Employee_EEmployeeType_0;

		// Token: 0x04003C1A RID: 15386
		private static readonly IntPtr NativeMethodInfoPtr_GetEmployeesByType_Public_List_1_Employee_EEmployeeType_0;

		// Token: 0x04003C1B RID: 15387
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003C1C RID: 15388
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04003C1D RID: 15389
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04003C1E RID: 15390
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04003C1F RID: 15391
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_CreateEmployee_311954683_Private_Void_Property_EEmployeeType_String_String_String_Boolean_Int32_Vector3_Quaternion_String_0;

		// Token: 0x04003C20 RID: 15392
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___CreateEmployee_311954683_Public_Void_Property_EEmployeeType_String_String_String_Boolean_Int32_Vector3_Quaternion_String_0;

		// Token: 0x04003C21 RID: 15393
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_CreateEmployee_311954683_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003C22 RID: 15394
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x020009D0 RID: 2512
		[Serializable]
		public class EmployeeAppearance : Il2CppSystem.Object
		{
			// Token: 0x0600CCB8 RID: 52408 RVA: 0x00315A98 File Offset: 0x00313C98
			// Note: this type is marked as 'beforefieldinit'.
			static EmployeeAppearance()
			{
				Il2CppClassPointerStore<EmployeeManager.EmployeeAppearance>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "EmployeeAppearance");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmployeeManager.EmployeeAppearance>.NativeClassPtr);
				EmployeeManager.EmployeeAppearance.NativeFieldInfoPtr_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager.EmployeeAppearance>.NativeClassPtr, "Settings");
				EmployeeManager.EmployeeAppearance.NativeFieldInfoPtr_Mugshot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager.EmployeeAppearance>.NativeClassPtr, "Mugshot");
				EmployeeManager.EmployeeAppearance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager.EmployeeAppearance>.NativeClassPtr, 100674438);
			}

			// Token: 0x0600CCB9 RID: 52409 RVA: 0x00315B00 File Offset: 0x00313D00
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EmployeeAppearance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EmployeeManager.EmployeeAppearance>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.EmployeeAppearance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CCBA RID: 52410 RVA: 0x000638EB File Offset: 0x00061AEB
			public EmployeeAppearance(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FC5 RID: 16325
			// (get) Token: 0x0600CCBB RID: 52411 RVA: 0x00315B3C File Offset: 0x00313D3C
			// (set) Token: 0x0600CCBC RID: 52412 RVA: 0x000638F4 File Offset: 0x00061AF4
			public unsafe AvatarSettings Settings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.EmployeeAppearance.NativeFieldInfoPtr_Settings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarSettings>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.EmployeeAppearance.NativeFieldInfoPtr_Settings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FC6 RID: 16326
			// (get) Token: 0x0600CCBD RID: 52413 RVA: 0x00315B6C File Offset: 0x00313D6C
			// (set) Token: 0x0600CCBE RID: 52414 RVA: 0x00063913 File Offset: 0x00061B13
			public unsafe Sprite Mugshot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.EmployeeAppearance.NativeFieldInfoPtr_Mugshot);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.EmployeeAppearance.NativeFieldInfoPtr_Mugshot), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008A67 RID: 35431
			private static readonly IntPtr NativeFieldInfoPtr_Settings;

			// Token: 0x04008A68 RID: 35432
			private static readonly IntPtr NativeFieldInfoPtr_Mugshot;

			// Token: 0x04008A69 RID: 35433
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020009D1 RID: 2513
		[ObfuscatedName("ScheduleOne.Employees.EmployeeManager+<>c__DisplayClass20_0")]
		public sealed class __c__DisplayClass20_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CCBF RID: 52415 RVA: 0x00315B9C File Offset: 0x00313D9C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_0()
			{
				Il2CppClassPointerStore<EmployeeManager.__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EmployeeManager>.NativeClassPtr, "<>c__DisplayClass20_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmployeeManager.__c__DisplayClass20_0>.NativeClassPtr);
				EmployeeManager.__c__DisplayClass20_0.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmployeeManager.__c__DisplayClass20_0>.NativeClassPtr, "type");
				EmployeeManager.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager.__c__DisplayClass20_0>.NativeClassPtr, 100674439);
				EmployeeManager.__c__DisplayClass20_0.NativeMethodInfoPtr__CreateEmployee_Server_b__0_Internal_Boolean_Quest_Employees_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmployeeManager.__c__DisplayClass20_0>.NativeClassPtr, 100674440);
			}

			// Token: 0x0600CCC0 RID: 52416 RVA: 0x00315C04 File Offset: 0x00313E04
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EmployeeManager.__c__DisplayClass20_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CCC1 RID: 52417 RVA: 0x00315C40 File Offset: 0x00313E40
			[CallerCount(0)]
			public unsafe bool _CreateEmployee_Server_b__0(Quest_Employees x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmployeeManager.__c__DisplayClass20_0.NativeMethodInfoPtr__CreateEmployee_Server_b__0_Internal_Boolean_Quest_Employees_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CCC2 RID: 52418 RVA: 0x00063932 File Offset: 0x00061B32
			public __c__DisplayClass20_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FC7 RID: 16327
			// (get) Token: 0x0600CCC3 RID: 52419 RVA: 0x00315C90 File Offset: 0x00313E90
			// (set) Token: 0x0600CCC4 RID: 52420 RVA: 0x0006393B File Offset: 0x00061B3B
			public unsafe EEmployeeType type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.__c__DisplayClass20_0.NativeFieldInfoPtr_type);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmployeeManager.__c__DisplayClass20_0.NativeFieldInfoPtr_type)) = value;
				}
			}

			// Token: 0x04008A6A RID: 35434
			private static readonly IntPtr NativeFieldInfoPtr_type;

			// Token: 0x04008A6B RID: 35435
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008A6C RID: 35436
			private static readonly IntPtr NativeMethodInfoPtr__CreateEmployee_Server_b__0_Internal_Boolean_Quest_Employees_0;
		}
	}
}
