using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Interaction;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000756 RID: 1878
	public class SoilPourer : GridItem
	{
		// Token: 0x0600B28F RID: 45711 RVA: 0x002C89A0 File Offset: 0x002C6BA0
		// Note: this type is marked as 'beforefieldinit'.
		static SoilPourer()
		{
			Il2CppClassPointerStore<SoilPourer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "SoilPourer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr);
			SoilPourer.NativeFieldInfoPtr__SoilID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, "<SoilID>k__BackingField");
			SoilPourer.NativeFieldInfoPtr_AnimationDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, "AnimationDuration");
			SoilPourer.NativeFieldInfoPtr_HandleIntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, "HandleIntObj");
			SoilPourer.NativeFieldInfoPtr_FillIntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, "FillIntObj");
			SoilPourer.NativeFieldInfoPtr_DirtPlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, "DirtPlane");
			SoilPourer.NativeFieldInfoPtr_Dirt_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, "Dirt_Min");
			SoilPourer.NativeFieldInfoPtr_Dirt_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, "Dirt_Max");
			SoilPourer.NativeFieldInfoPtr_PourParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, "PourParticles");
			SoilPourer.NativeFieldInfoPtr_PourAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, "PourAnimation");
			SoilPourer.NativeFieldInfoPtr_FillSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, "FillSound");
			SoilPourer.NativeFieldInfoPtr_ActivateSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, "ActivateSound");
			SoilPourer.NativeFieldInfoPtr_DirtPourSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, "DirtPourSound");
			SoilPourer.NativeFieldInfoPtr_isDispensing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, "isDispensing");
			SoilPourer.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.ObjectScripts.SoilPourerAssembly-CSharp.dll_Excuted");
			SoilPourer.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.ObjectScripts.SoilPourerAssembly-CSharp.dll_Excuted");
			SoilPourer.NativeMethodInfoPtr_get_SoilID_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685304);
			SoilPourer.NativeMethodInfoPtr_set_SoilID_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685305);
			SoilPourer.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685306);
			SoilPourer.NativeMethodInfoPtr_HandleHovered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685307);
			SoilPourer.NativeMethodInfoPtr_HandleInteracted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685308);
			SoilPourer.NativeMethodInfoPtr_SendPourSoil_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685309);
			SoilPourer.NativeMethodInfoPtr_PourSoil_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685310);
			SoilPourer.NativeMethodInfoPtr_ApplySoil_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685311);
			SoilPourer.NativeMethodInfoPtr_FillHovered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685312);
			SoilPourer.NativeMethodInfoPtr_FillInteracted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685313);
			SoilPourer.NativeMethodInfoPtr_SendSoil_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685314);
			SoilPourer.NativeMethodInfoPtr_SetSoil_Protected_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685315);
			SoilPourer.NativeMethodInfoPtr_SetSoilLevel_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685316);
			SoilPourer.NativeMethodInfoPtr_GetPots_Protected_Virtual_New_List_1_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685317);
			SoilPourer.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685318);
			SoilPourer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685319);
			SoilPourer.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685320);
			SoilPourer.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685321);
			SoilPourer.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685322);
			SoilPourer.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685323);
			SoilPourer.NativeMethodInfoPtr_RpcWriter___Server_SendPourSoil_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685324);
			SoilPourer.NativeMethodInfoPtr_RpcLogic___SendPourSoil_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685325);
			SoilPourer.NativeMethodInfoPtr_RpcReader___Server_SendPourSoil_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685326);
			SoilPourer.NativeMethodInfoPtr_RpcWriter___Observers_PourSoil_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685327);
			SoilPourer.NativeMethodInfoPtr_RpcLogic___PourSoil_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685328);
			SoilPourer.NativeMethodInfoPtr_RpcReader___Observers_PourSoil_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685329);
			SoilPourer.NativeMethodInfoPtr_RpcWriter___Server_SendSoil_3615296227_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685330);
			SoilPourer.NativeMethodInfoPtr_RpcLogic___SendSoil_3615296227_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685331);
			SoilPourer.NativeMethodInfoPtr_RpcReader___Server_SendSoil_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685332);
			SoilPourer.NativeMethodInfoPtr_RpcWriter___Observers_SetSoil_2971853958_Private_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685333);
			SoilPourer.NativeMethodInfoPtr_RpcLogic___SetSoil_2971853958_Protected_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685334);
			SoilPourer.NativeMethodInfoPtr_RpcReader___Observers_SetSoil_2971853958_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685335);
			SoilPourer.NativeMethodInfoPtr_RpcWriter___Target_SetSoil_2971853958_Private_Void_NetworkConnection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685336);
			SoilPourer.NativeMethodInfoPtr_RpcReader___Target_SetSoil_2971853958_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685337);
			SoilPourer.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, 100685338);
		}

		// Token: 0x17003775 RID: 14197
		// (get) Token: 0x0600B290 RID: 45712 RVA: 0x002C8DB8 File Offset: 0x002C6FB8
		// (set) Token: 0x0600B291 RID: 45713 RVA: 0x002C8DF0 File Offset: 0x002C6FF0
		public unsafe string SoilID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_get_SoilID_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_set_SoilID_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600B292 RID: 45714 RVA: 0x002C8E34 File Offset: 0x002C7034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307332, XrefRangeEnd = 307341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SoilPourer.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B293 RID: 45715 RVA: 0x002C8E84 File Offset: 0x002C7084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307341, XrefRangeEnd = 307345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleHovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_HandleHovered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B294 RID: 45716 RVA: 0x002C8EB8 File Offset: 0x002C70B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307345, XrefRangeEnd = 307366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleInteracted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_HandleInteracted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B295 RID: 45717 RVA: 0x002C8EEC File Offset: 0x002C70EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307366, XrefRangeEnd = 307387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendPourSoil()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_SendPourSoil_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B296 RID: 45718 RVA: 0x002C8F20 File Offset: 0x002C7120
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 307408, RefRangeEnd = 307411, XrefRangeStart = 307387, XrefRangeEnd = 307408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PourSoil()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_PourSoil_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B297 RID: 45719 RVA: 0x002C8F54 File Offset: 0x002C7154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307411, XrefRangeEnd = 307424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplySoil(string ID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_ApplySoil_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B298 RID: 45720 RVA: 0x002C8F98 File Offset: 0x002C7198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307424, XrefRangeEnd = 307442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FillHovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_FillHovered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B299 RID: 45721 RVA: 0x002C8FCC File Offset: 0x002C71CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307442, XrefRangeEnd = 307486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FillInteracted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_FillInteracted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B29A RID: 45722 RVA: 0x002C9000 File Offset: 0x002C7200
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 307508, RefRangeEnd = 307509, XrefRangeStart = 307486, XrefRangeEnd = 307508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendSoil(string ID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_SendSoil_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B29B RID: 45723 RVA: 0x002C9044 File Offset: 0x002C7244
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 307551, RefRangeEnd = 307555, XrefRangeStart = 307509, XrefRangeEnd = 307551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSoil(NetworkConnection conn, string ID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_SetSoil_Protected_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B29C RID: 45724 RVA: 0x002C9098 File Offset: 0x002C7298
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 307563, RefRangeEnd = 307565, XrefRangeStart = 307555, XrefRangeEnd = 307563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSoilLevel(float level)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref level;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_SetSoilLevel_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B29D RID: 45725 RVA: 0x002C90D8 File Offset: 0x002C72D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307565, XrefRangeEnd = 307624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<Pot> GetPots()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SoilPourer.NativeMethodInfoPtr_GetPots_Protected_Virtual_New_List_1_Pot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Pot>>(intPtr3) : null;
		}

		// Token: 0x0600B29E RID: 45726 RVA: 0x002C9124 File Offset: 0x002C7324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307624, XrefRangeEnd = 307629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SoilPourer.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600B29F RID: 45727 RVA: 0x002C9168 File Offset: 0x002C7368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307629, XrefRangeEnd = 307633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SoilPourer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2A0 RID: 45728 RVA: 0x002C91A4 File Offset: 0x002C73A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307633, XrefRangeEnd = 307638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600B2A1 RID: 45729 RVA: 0x002C91E4 File Offset: 0x002C73E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307638, XrefRangeEnd = 307671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SoilPourer.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2A2 RID: 45730 RVA: 0x002C9220 File Offset: 0x002C7420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307671, XrefRangeEnd = 307672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SoilPourer.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2A3 RID: 45731 RVA: 0x002C925C File Offset: 0x002C745C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SoilPourer.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2A4 RID: 45732 RVA: 0x002C9298 File Offset: 0x002C7498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307672, XrefRangeEnd = 307690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendPourSoil_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_RpcWriter___Server_SendPourSoil_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2A5 RID: 45733 RVA: 0x002C92CC File Offset: 0x002C74CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 307408, RefRangeEnd = 307411, XrefRangeStart = 307408, XrefRangeEnd = 307411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendPourSoil_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_RpcLogic___SendPourSoil_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2A6 RID: 45734 RVA: 0x002C9300 File Offset: 0x002C7500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307690, XrefRangeEnd = 307693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendPourSoil_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_RpcReader___Server_SendPourSoil_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2A7 RID: 45735 RVA: 0x002C9364 File Offset: 0x002C7564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307693, XrefRangeEnd = 307711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_PourSoil_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_RpcWriter___Observers_PourSoil_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2A8 RID: 45736 RVA: 0x002C9398 File Offset: 0x002C7598
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 307717, RefRangeEnd = 307720, XrefRangeStart = 307711, XrefRangeEnd = 307717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___PourSoil_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_RpcLogic___PourSoil_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2A9 RID: 45737 RVA: 0x002C93CC File Offset: 0x002C75CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307720, XrefRangeEnd = 307723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_PourSoil_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_RpcReader___Observers_PourSoil_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2AA RID: 45738 RVA: 0x002C941C File Offset: 0x002C761C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307723, XrefRangeEnd = 307742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendSoil_3615296227(string ID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_RpcWriter___Server_SendSoil_3615296227_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2AB RID: 45739 RVA: 0x002C9460 File Offset: 0x002C7660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307742, XrefRangeEnd = 307743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendSoil_3615296227(string ID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(ID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_RpcLogic___SendSoil_3615296227_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2AC RID: 45740 RVA: 0x002C94A4 File Offset: 0x002C76A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307743, XrefRangeEnd = 307747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendSoil_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_RpcReader___Server_SendSoil_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2AD RID: 45741 RVA: 0x002C9508 File Offset: 0x002C7708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307747, XrefRangeEnd = 307766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetSoil_2971853958(NetworkConnection conn, string ID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_RpcWriter___Observers_SetSoil_2971853958_Private_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2AE RID: 45742 RVA: 0x002C955C File Offset: 0x002C775C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 307775, RefRangeEnd = 307778, XrefRangeStart = 307766, XrefRangeEnd = 307775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetSoil_2971853958(NetworkConnection conn, string ID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_RpcLogic___SetSoil_2971853958_Protected_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2AF RID: 45743 RVA: 0x002C95B0 File Offset: 0x002C77B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307778, XrefRangeEnd = 307782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetSoil_2971853958(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_RpcReader___Observers_SetSoil_2971853958_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2B0 RID: 45744 RVA: 0x002C9600 File Offset: 0x002C7800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307782, XrefRangeEnd = 307801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetSoil_2971853958(NetworkConnection conn, string ID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_RpcWriter___Target_SetSoil_2971853958_Private_Void_NetworkConnection_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2B1 RID: 45745 RVA: 0x002C9654 File Offset: 0x002C7854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307801, XrefRangeEnd = 307805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetSoil_2971853958(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.NativeMethodInfoPtr_RpcReader___Target_SetSoil_2971853958_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2B2 RID: 45746 RVA: 0x002C96A4 File Offset: 0x002C78A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 290619, RefRangeEnd = 290620, XrefRangeStart = 290619, XrefRangeEnd = 290620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SoilPourer.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B2B3 RID: 45747 RVA: 0x00057920 File Offset: 0x00055B20
		public SoilPourer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003766 RID: 14182
		// (get) Token: 0x0600B2B4 RID: 45748 RVA: 0x002C96E0 File Offset: 0x002C78E0
		// (set) Token: 0x0600B2B5 RID: 45749 RVA: 0x00057929 File Offset: 0x00055B29
		public unsafe string _SoilID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr__SoilID_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr__SoilID_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003767 RID: 14183
		// (get) Token: 0x0600B2B6 RID: 45750 RVA: 0x002C9708 File Offset: 0x002C7908
		// (set) Token: 0x0600B2B7 RID: 45751 RVA: 0x00057948 File Offset: 0x00055B48
		public unsafe float AnimationDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_AnimationDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_AnimationDuration)) = value;
			}
		}

		// Token: 0x17003768 RID: 14184
		// (get) Token: 0x0600B2B8 RID: 45752 RVA: 0x002C9730 File Offset: 0x002C7930
		// (set) Token: 0x0600B2B9 RID: 45753 RVA: 0x00057963 File Offset: 0x00055B63
		public unsafe InteractableObject HandleIntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_HandleIntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_HandleIntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003769 RID: 14185
		// (get) Token: 0x0600B2BA RID: 45754 RVA: 0x002C9760 File Offset: 0x002C7960
		// (set) Token: 0x0600B2BB RID: 45755 RVA: 0x00057982 File Offset: 0x00055B82
		public unsafe InteractableObject FillIntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_FillIntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_FillIntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700376A RID: 14186
		// (get) Token: 0x0600B2BC RID: 45756 RVA: 0x002C9790 File Offset: 0x002C7990
		// (set) Token: 0x0600B2BD RID: 45757 RVA: 0x000579A1 File Offset: 0x00055BA1
		public unsafe MeshRenderer DirtPlane
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_DirtPlane);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_DirtPlane), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700376B RID: 14187
		// (get) Token: 0x0600B2BE RID: 45758 RVA: 0x002C97C0 File Offset: 0x002C79C0
		// (set) Token: 0x0600B2BF RID: 45759 RVA: 0x000579C0 File Offset: 0x00055BC0
		public unsafe Transform Dirt_Min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_Dirt_Min);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_Dirt_Min), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700376C RID: 14188
		// (get) Token: 0x0600B2C0 RID: 45760 RVA: 0x002C97F0 File Offset: 0x002C79F0
		// (set) Token: 0x0600B2C1 RID: 45761 RVA: 0x000579DF File Offset: 0x00055BDF
		public unsafe Transform Dirt_Max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_Dirt_Max);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_Dirt_Max), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700376D RID: 14189
		// (get) Token: 0x0600B2C2 RID: 45762 RVA: 0x002C9820 File Offset: 0x002C7A20
		// (set) Token: 0x0600B2C3 RID: 45763 RVA: 0x000579FE File Offset: 0x00055BFE
		public unsafe ParticleSystem PourParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_PourParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_PourParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700376E RID: 14190
		// (get) Token: 0x0600B2C4 RID: 45764 RVA: 0x002C9850 File Offset: 0x002C7A50
		// (set) Token: 0x0600B2C5 RID: 45765 RVA: 0x00057A1D File Offset: 0x00055C1D
		public unsafe Animation PourAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_PourAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_PourAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700376F RID: 14191
		// (get) Token: 0x0600B2C6 RID: 45766 RVA: 0x002C9880 File Offset: 0x002C7A80
		// (set) Token: 0x0600B2C7 RID: 45767 RVA: 0x00057A3C File Offset: 0x00055C3C
		public unsafe AudioSourceController FillSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_FillSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_FillSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003770 RID: 14192
		// (get) Token: 0x0600B2C8 RID: 45768 RVA: 0x002C98B0 File Offset: 0x002C7AB0
		// (set) Token: 0x0600B2C9 RID: 45769 RVA: 0x00057A5B File Offset: 0x00055C5B
		public unsafe AudioSourceController ActivateSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_ActivateSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_ActivateSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003771 RID: 14193
		// (get) Token: 0x0600B2CA RID: 45770 RVA: 0x002C98E0 File Offset: 0x002C7AE0
		// (set) Token: 0x0600B2CB RID: 45771 RVA: 0x00057A7A File Offset: 0x00055C7A
		public unsafe AudioSourceController DirtPourSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_DirtPourSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_DirtPourSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003772 RID: 14194
		// (get) Token: 0x0600B2CC RID: 45772 RVA: 0x002C9910 File Offset: 0x002C7B10
		// (set) Token: 0x0600B2CD RID: 45773 RVA: 0x00057A99 File Offset: 0x00055C99
		public unsafe bool isDispensing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_isDispensing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_isDispensing)) = value;
			}
		}

		// Token: 0x17003773 RID: 14195
		// (get) Token: 0x0600B2CE RID: 45774 RVA: 0x002C9938 File Offset: 0x002C7B38
		// (set) Token: 0x0600B2CF RID: 45775 RVA: 0x00057AB4 File Offset: 0x00055CB4
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17003774 RID: 14196
		// (get) Token: 0x0600B2D0 RID: 45776 RVA: 0x002C9960 File Offset: 0x002C7B60
		// (set) Token: 0x0600B2D1 RID: 45777 RVA: 0x00057ACF File Offset: 0x00055CCF
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x0400786D RID: 30829
		private static readonly IntPtr NativeFieldInfoPtr__SoilID_k__BackingField;

		// Token: 0x0400786E RID: 30830
		private static readonly IntPtr NativeFieldInfoPtr_AnimationDuration;

		// Token: 0x0400786F RID: 30831
		private static readonly IntPtr NativeFieldInfoPtr_HandleIntObj;

		// Token: 0x04007870 RID: 30832
		private static readonly IntPtr NativeFieldInfoPtr_FillIntObj;

		// Token: 0x04007871 RID: 30833
		private static readonly IntPtr NativeFieldInfoPtr_DirtPlane;

		// Token: 0x04007872 RID: 30834
		private static readonly IntPtr NativeFieldInfoPtr_Dirt_Min;

		// Token: 0x04007873 RID: 30835
		private static readonly IntPtr NativeFieldInfoPtr_Dirt_Max;

		// Token: 0x04007874 RID: 30836
		private static readonly IntPtr NativeFieldInfoPtr_PourParticles;

		// Token: 0x04007875 RID: 30837
		private static readonly IntPtr NativeFieldInfoPtr_PourAnimation;

		// Token: 0x04007876 RID: 30838
		private static readonly IntPtr NativeFieldInfoPtr_FillSound;

		// Token: 0x04007877 RID: 30839
		private static readonly IntPtr NativeFieldInfoPtr_ActivateSound;

		// Token: 0x04007878 RID: 30840
		private static readonly IntPtr NativeFieldInfoPtr_DirtPourSound;

		// Token: 0x04007879 RID: 30841
		private static readonly IntPtr NativeFieldInfoPtr_isDispensing;

		// Token: 0x0400787A RID: 30842
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400787B RID: 30843
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400787C RID: 30844
		private static readonly IntPtr NativeMethodInfoPtr_get_SoilID_Public_get_String_0;

		// Token: 0x0400787D RID: 30845
		private static readonly IntPtr NativeMethodInfoPtr_set_SoilID_Protected_set_Void_String_0;

		// Token: 0x0400787E RID: 30846
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x0400787F RID: 30847
		private static readonly IntPtr NativeMethodInfoPtr_HandleHovered_Public_Void_0;

		// Token: 0x04007880 RID: 30848
		private static readonly IntPtr NativeMethodInfoPtr_HandleInteracted_Public_Void_0;

		// Token: 0x04007881 RID: 30849
		private static readonly IntPtr NativeMethodInfoPtr_SendPourSoil_Private_Void_0;

		// Token: 0x04007882 RID: 30850
		private static readonly IntPtr NativeMethodInfoPtr_PourSoil_Private_Void_0;

		// Token: 0x04007883 RID: 30851
		private static readonly IntPtr NativeMethodInfoPtr_ApplySoil_Private_Void_String_0;

		// Token: 0x04007884 RID: 30852
		private static readonly IntPtr NativeMethodInfoPtr_FillHovered_Public_Void_0;

		// Token: 0x04007885 RID: 30853
		private static readonly IntPtr NativeMethodInfoPtr_FillInteracted_Public_Void_0;

		// Token: 0x04007886 RID: 30854
		private static readonly IntPtr NativeMethodInfoPtr_SendSoil_Public_Void_String_0;

		// Token: 0x04007887 RID: 30855
		private static readonly IntPtr NativeMethodInfoPtr_SetSoil_Protected_Void_NetworkConnection_String_0;

		// Token: 0x04007888 RID: 30856
		private static readonly IntPtr NativeMethodInfoPtr_SetSoilLevel_Public_Void_Single_0;

		// Token: 0x04007889 RID: 30857
		private static readonly IntPtr NativeMethodInfoPtr_GetPots_Protected_Virtual_New_List_1_Pot_0;

		// Token: 0x0400788A RID: 30858
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0;

		// Token: 0x0400788B RID: 30859
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400788C RID: 30860
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x0400788D RID: 30861
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400788E RID: 30862
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400788F RID: 30863
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04007890 RID: 30864
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendPourSoil_2166136261_Private_Void_0;

		// Token: 0x04007891 RID: 30865
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendPourSoil_2166136261_Private_Void_0;

		// Token: 0x04007892 RID: 30866
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendPourSoil_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04007893 RID: 30867
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_PourSoil_2166136261_Private_Void_0;

		// Token: 0x04007894 RID: 30868
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___PourSoil_2166136261_Private_Void_0;

		// Token: 0x04007895 RID: 30869
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_PourSoil_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04007896 RID: 30870
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendSoil_3615296227_Private_Void_String_0;

		// Token: 0x04007897 RID: 30871
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendSoil_3615296227_Public_Void_String_0;

		// Token: 0x04007898 RID: 30872
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendSoil_3615296227_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04007899 RID: 30873
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetSoil_2971853958_Private_Void_NetworkConnection_String_0;

		// Token: 0x0400789A RID: 30874
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetSoil_2971853958_Protected_Void_NetworkConnection_String_0;

		// Token: 0x0400789B RID: 30875
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetSoil_2971853958_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400789C RID: 30876
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetSoil_2971853958_Private_Void_NetworkConnection_String_0;

		// Token: 0x0400789D RID: 30877
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetSoil_2971853958_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400789E RID: 30878
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000BF5 RID: 3061
		[ObfuscatedName("ScheduleOne.ObjectScripts.SoilPourer+<<PourSoil>g__PourRoutine|20_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600DF82 RID: 57218 RVA: 0x0034A9C4 File Offset: 0x00348BC4
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique()
			{
				Il2CppClassPointerStore<SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SoilPourer>.NativeClassPtr, "<<PourSoil>g__PourRoutine|20_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique>.NativeClassPtr);
				SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique>.NativeClassPtr, "<>1__state");
				SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique>.NativeClassPtr, "<>2__current");
				SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique>.NativeClassPtr, "<>4__this");
				SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeFieldInfoPtr__targetPot_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique>.NativeClassPtr, "<targetPot>5__2");
				SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique>.NativeClassPtr, "<i>5__3");
				SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique>.NativeClassPtr, 100685339);
				SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique>.NativeClassPtr, 100685340);
				SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique>.NativeClassPtr, 100685341);
				SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique>.NativeClassPtr, 100685342);
				SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique>.NativeClassPtr, 100685343);
				SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique>.NativeClassPtr, 100685344);
			}

			// Token: 0x0600DF83 RID: 57219 RVA: 0x0034AACC File Offset: 0x00348CCC
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF84 RID: 57220 RVA: 0x0034AB14 File Offset: 0x00348D14
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF85 RID: 57221 RVA: 0x0034AB48 File Offset: 0x00348D48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307318, XrefRangeEnd = 307327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004549 RID: 17737
			// (get) Token: 0x0600DF86 RID: 57222 RVA: 0x0034AB84 File Offset: 0x00348D84
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DF87 RID: 57223 RVA: 0x0034ABC4 File Offset: 0x00348DC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307327, XrefRangeEnd = 307332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700454A RID: 17738
			// (get) Token: 0x0600DF88 RID: 57224 RVA: 0x0034ABF8 File Offset: 0x00348DF8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DF89 RID: 57225 RVA: 0x0006CFBB File Offset: 0x0006B1BB
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004544 RID: 17732
			// (get) Token: 0x0600DF8A RID: 57226 RVA: 0x0034AC38 File Offset: 0x00348E38
			// (set) Token: 0x0600DF8B RID: 57227 RVA: 0x0006CFC4 File Offset: 0x0006B1C4
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004545 RID: 17733
			// (get) Token: 0x0600DF8C RID: 57228 RVA: 0x0034AC60 File Offset: 0x00348E60
			// (set) Token: 0x0600DF8D RID: 57229 RVA: 0x0006CFDF File Offset: 0x0006B1DF
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004546 RID: 17734
			// (get) Token: 0x0600DF8E RID: 57230 RVA: 0x0034AC90 File Offset: 0x00348E90
			// (set) Token: 0x0600DF8F RID: 57231 RVA: 0x0006CFFE File Offset: 0x0006B1FE
			public unsafe SoilPourer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SoilPourer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004547 RID: 17735
			// (get) Token: 0x0600DF90 RID: 57232 RVA: 0x0034ACC0 File Offset: 0x00348EC0
			// (set) Token: 0x0600DF91 RID: 57233 RVA: 0x0006D01D File Offset: 0x0006B21D
			public unsafe Pot _targetPot_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeFieldInfoPtr__targetPot_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pot>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeFieldInfoPtr__targetPot_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004548 RID: 17736
			// (get) Token: 0x0600DF92 RID: 57234 RVA: 0x0034ACF0 File Offset: 0x00348EF0
			// (set) Token: 0x0600DF93 RID: 57235 RVA: 0x0006D03C File Offset: 0x0006B23C
			public unsafe float _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSoPoSiObObUnique.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x040095B9 RID: 38329
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040095BA RID: 38330
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040095BB RID: 38331
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040095BC RID: 38332
			private static readonly IntPtr NativeFieldInfoPtr__targetPot_5__2;

			// Token: 0x040095BD RID: 38333
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x040095BE RID: 38334
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040095BF RID: 38335
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040095C0 RID: 38336
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040095C1 RID: 38337
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040095C2 RID: 38338
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040095C3 RID: 38339
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
