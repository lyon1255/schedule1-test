using System;
using Il2CppEPOOutline;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Construction.Features;
using Il2CppScheduleOne.EntityFramework;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.ConstructableScripts
{
	// Token: 0x020005CA RID: 1482
	public class Constructable : NetworkBehaviour
	{
		// Token: 0x06008244 RID: 33348 RVA: 0x0022AAC8 File Offset: 0x00228CC8
		// Note: this type is marked as 'beforefieldinit'.
		static Constructable()
		{
			Il2CppClassPointerStore<Constructable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ConstructableScripts", "Constructable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Constructable>.NativeClassPtr);
			Constructable.NativeFieldInfoPtr_isStatic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable>.NativeClassPtr, "isStatic");
			Constructable.NativeFieldInfoPtr_constructableName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable>.NativeClassPtr, "constructableName");
			Constructable.NativeFieldInfoPtr_constructableDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable>.NativeClassPtr, "constructableDescription");
			Constructable.NativeFieldInfoPtr_constructableAssetPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable>.NativeClassPtr, "constructableAssetPath");
			Constructable.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable>.NativeClassPtr, "ID");
			Constructable.NativeFieldInfoPtr_constructableIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable>.NativeClassPtr, "constructableIcon");
			Constructable.NativeFieldInfoPtr_boundingBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable>.NativeClassPtr, "boundingBox");
			Constructable.NativeFieldInfoPtr_constructionHandler_Asset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable>.NativeClassPtr, "constructionHandler_Asset");
			Constructable.NativeFieldInfoPtr_outlineRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable>.NativeClassPtr, "outlineRenderers");
			Constructable.NativeFieldInfoPtr_outlineEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable>.NativeClassPtr, "outlineEffect");
			Constructable.NativeFieldInfoPtr_features = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable>.NativeClassPtr, "features");
			Constructable.NativeFieldInfoPtr__isVisible_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable>.NativeClassPtr, "<isVisible>k__BackingField");
			Constructable.NativeFieldInfoPtr_isDestroyed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable>.NativeClassPtr, "isDestroyed");
			Constructable.NativeFieldInfoPtr_originalLayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable>.NativeClassPtr, "originalLayers");
			Constructable.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.ConstructableScripts.ConstructableAssembly-CSharp.dll_Excuted");
			Constructable.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Constructable>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.ConstructableScripts.ConstructableAssembly-CSharp.dll_Excuted");
			Constructable.NativeMethodInfoPtr_get_IsStatic_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679586);
			Constructable.NativeMethodInfoPtr_get_ConstructableName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679587);
			Constructable.NativeMethodInfoPtr_get_ConstructableDescription_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679588);
			Constructable.NativeMethodInfoPtr_get_ConstructableAssetPath_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679589);
			Constructable.NativeMethodInfoPtr_get_PrefabID_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679590);
			Constructable.NativeMethodInfoPtr_get_ConstructableIcon_Public_get_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679591);
			Constructable.NativeMethodInfoPtr_get__constructionHandler_Asset_Public_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679592);
			Constructable.NativeMethodInfoPtr_get_isVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679593);
			Constructable.NativeMethodInfoPtr_set_isVisible_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679594);
			Constructable.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679595);
			Constructable.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679596);
			Constructable.NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_New_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679597);
			Constructable.NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679598);
			Constructable.NativeMethodInfoPtr_DestroyConstructable_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679599);
			Constructable.NativeMethodInfoPtr_Destroy_Networked_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679600);
			Constructable.NativeMethodInfoPtr_DestroyConstructableWrapper_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679601);
			Constructable.NativeMethodInfoPtr_CanBeModified_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679602);
			Constructable.NativeMethodInfoPtr_CanBePickedUpByHand_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679603);
			Constructable.NativeMethodInfoPtr_CanBeSelected_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679604);
			Constructable.NativeMethodInfoPtr_GetBuildableVersionAssetPath_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679605);
			Constructable.NativeMethodInfoPtr_ShowOutline_Public_Void_EOutlineColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679606);
			Constructable.NativeMethodInfoPtr_HideOutline_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679607);
			Constructable.NativeMethodInfoPtr_GetCosmeticCenter_Public_Virtual_New_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679608);
			Constructable.NativeMethodInfoPtr_GetBoundingBoxLongestSide_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679609);
			Constructable.NativeMethodInfoPtr_SetInvisible_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679610);
			Constructable.NativeMethodInfoPtr_RestoreVisibility_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679611);
			Constructable.NativeMethodInfoPtr_SetLayerRecursively_Public_Void_GameObject_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679612);
			Constructable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679613);
			Constructable.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679614);
			Constructable.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679615);
			Constructable.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679616);
			Constructable.NativeMethodInfoPtr_RpcWriter___Server_Destroy_Networked_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679617);
			Constructable.NativeMethodInfoPtr_RpcLogic___Destroy_Networked_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679618);
			Constructable.NativeMethodInfoPtr_RpcReader___Server_Destroy_Networked_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679619);
			Constructable.NativeMethodInfoPtr_RpcWriter___Observers_DestroyConstructableWrapper_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679620);
			Constructable.NativeMethodInfoPtr_RpcLogic___DestroyConstructableWrapper_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679621);
			Constructable.NativeMethodInfoPtr_RpcReader___Observers_DestroyConstructableWrapper_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679622);
			Constructable.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Constructable>.NativeClassPtr, 100679623);
		}

		// Token: 0x1700277F RID: 10111
		// (get) Token: 0x06008245 RID: 33349 RVA: 0x0022AF30 File Offset: 0x00229130
		public unsafe bool IsStatic
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable.NativeMethodInfoPtr_get_IsStatic_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002780 RID: 10112
		// (get) Token: 0x06008246 RID: 33350 RVA: 0x0022AF6C File Offset: 0x0022916C
		public unsafe string ConstructableName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable.NativeMethodInfoPtr_get_ConstructableName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17002781 RID: 10113
		// (get) Token: 0x06008247 RID: 33351 RVA: 0x0022AFA4 File Offset: 0x002291A4
		public unsafe string ConstructableDescription
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable.NativeMethodInfoPtr_get_ConstructableDescription_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17002782 RID: 10114
		// (get) Token: 0x06008248 RID: 33352 RVA: 0x0022AFDC File Offset: 0x002291DC
		public unsafe string ConstructableAssetPath
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable.NativeMethodInfoPtr_get_ConstructableAssetPath_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17002783 RID: 10115
		// (get) Token: 0x06008249 RID: 33353 RVA: 0x0022B014 File Offset: 0x00229214
		public unsafe string PrefabID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable.NativeMethodInfoPtr_get_PrefabID_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17002784 RID: 10116
		// (get) Token: 0x0600824A RID: 33354 RVA: 0x0022B04C File Offset: 0x0022924C
		public unsafe Sprite ConstructableIcon
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable.NativeMethodInfoPtr_get_ConstructableIcon_Public_get_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}
		}

		// Token: 0x17002785 RID: 10117
		// (get) Token: 0x0600824B RID: 33355 RVA: 0x0022B08C File Offset: 0x0022928C
		public unsafe GameObject _constructionHandler_Asset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable.NativeMethodInfoPtr_get__constructionHandler_Asset_Public_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x17002786 RID: 10118
		// (get) Token: 0x0600824C RID: 33356 RVA: 0x0022B0CC File Offset: 0x002292CC
		// (set) Token: 0x0600824D RID: 33357 RVA: 0x0022B108 File Offset: 0x00229308
		public unsafe bool isVisible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable.NativeMethodInfoPtr_get_isVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable.NativeMethodInfoPtr_set_isVisible_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600824E RID: 33358 RVA: 0x0022B148 File Offset: 0x00229348
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 245777, RefRangeEnd = 245778, XrefRangeStart = 245776, XrefRangeEnd = 245777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600824F RID: 33359 RVA: 0x0022B184 File Offset: 0x00229384
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008250 RID: 33360 RVA: 0x0022B1C0 File Offset: 0x002293C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245778, XrefRangeEnd = 245781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanBeDestroyed(out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable.NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_New_Boolean_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06008251 RID: 33361 RVA: 0x0022B224 File Offset: 0x00229424
		[CallerCount(0)]
		public unsafe virtual bool CanBeDestroyed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable.NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008252 RID: 33362 RVA: 0x0022B26C File Offset: 0x0022946C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 245808, RefRangeEnd = 245809, XrefRangeStart = 245781, XrefRangeEnd = 245808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DestroyConstructable(bool callOnServer = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref callOnServer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable.NativeMethodInfoPtr_DestroyConstructable_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008253 RID: 33363 RVA: 0x0022B2B8 File Offset: 0x002294B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245809, XrefRangeEnd = 245827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Destroy_Networked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable.NativeMethodInfoPtr_Destroy_Networked_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008254 RID: 33364 RVA: 0x0022B2EC File Offset: 0x002294EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245827, XrefRangeEnd = 245845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyConstructableWrapper()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable.NativeMethodInfoPtr_DestroyConstructableWrapper_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008255 RID: 33365 RVA: 0x0022B320 File Offset: 0x00229520
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 30137, RefRangeEnd = 30157, XrefRangeStart = 30137, XrefRangeEnd = 30157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanBeModified()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable.NativeMethodInfoPtr_CanBeModified_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008256 RID: 33366 RVA: 0x0022B368 File Offset: 0x00229568
		[CallerCount(183)]
		[CachedScanResults(RefRangeStart = 35949, RefRangeEnd = 36132, XrefRangeStart = 35949, XrefRangeEnd = 36132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanBePickedUpByHand()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable.NativeMethodInfoPtr_CanBePickedUpByHand_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008257 RID: 33367 RVA: 0x0022B3B0 File Offset: 0x002295B0
		[CallerCount(0)]
		public unsafe virtual bool CanBeSelected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable.NativeMethodInfoPtr_CanBeSelected_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008258 RID: 33368 RVA: 0x0022B3F8 File Offset: 0x002295F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245845, XrefRangeEnd = 245847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetBuildableVersionAssetPath()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable.NativeMethodInfoPtr_GetBuildableVersionAssetPath_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06008259 RID: 33369 RVA: 0x0022B43C File Offset: 0x0022963C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 245890, RefRangeEnd = 245893, XrefRangeStart = 245847, XrefRangeEnd = 245890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowOutline(BuildableItem.EOutlineColor color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable.NativeMethodInfoPtr_ShowOutline_Public_Void_EOutlineColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600825A RID: 33370 RVA: 0x0022B47C File Offset: 0x0022967C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 245898, RefRangeEnd = 245900, XrefRangeStart = 245893, XrefRangeEnd = 245898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HideOutline()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable.NativeMethodInfoPtr_HideOutline_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600825B RID: 33371 RVA: 0x0022B4B0 File Offset: 0x002296B0
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 136690, RefRangeEnd = 136702, XrefRangeStart = 136690, XrefRangeEnd = 136702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Vector3 GetCosmeticCenter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable.NativeMethodInfoPtr_GetCosmeticCenter_Public_Virtual_New_Vector3_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600825C RID: 33372 RVA: 0x0022B4F8 File Offset: 0x002296F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 245903, RefRangeEnd = 245904, XrefRangeStart = 245900, XrefRangeEnd = 245903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetBoundingBoxLongestSide()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable.NativeMethodInfoPtr_GetBoundingBoxLongestSide_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600825D RID: 33373 RVA: 0x0022B534 File Offset: 0x00229734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245904, XrefRangeEnd = 245909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetInvisible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable.NativeMethodInfoPtr_SetInvisible_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600825E RID: 33374 RVA: 0x0022B570 File Offset: 0x00229770
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 245932, RefRangeEnd = 245933, XrefRangeStart = 245909, XrefRangeEnd = 245932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RestoreVisibility()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable.NativeMethodInfoPtr_RestoreVisibility_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600825F RID: 33375 RVA: 0x0022B5AC File Offset: 0x002297AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 245965, RefRangeEnd = 245967, XrefRangeStart = 245933, XrefRangeEnd = 245965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLayerRecursively(GameObject go, int layerNumber)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(go);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerNumber;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable.NativeMethodInfoPtr_SetLayerRecursively_Public_Void_GameObject_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008260 RID: 33376 RVA: 0x0022B5FC File Offset: 0x002297FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 246002, RefRangeEnd = 246003, XrefRangeStart = 245967, XrefRangeEnd = 246002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Constructable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Constructable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008261 RID: 33377 RVA: 0x0022B638 File Offset: 0x00229838
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 246017, RefRangeEnd = 246018, XrefRangeStart = 246003, XrefRangeEnd = 246017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008262 RID: 33378 RVA: 0x0022B674 File Offset: 0x00229874
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 234139, RefRangeEnd = 234140, XrefRangeStart = 234139, XrefRangeEnd = 234140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008263 RID: 33379 RVA: 0x0022B6B0 File Offset: 0x002298B0
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008264 RID: 33380 RVA: 0x0022B6EC File Offset: 0x002298EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_Destroy_Networked_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable.NativeMethodInfoPtr_RpcWriter___Server_Destroy_Networked_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008265 RID: 33381 RVA: 0x0022B720 File Offset: 0x00229920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246018, XrefRangeEnd = 246047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Destroy_Networked_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable.NativeMethodInfoPtr_RpcLogic___Destroy_Networked_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008266 RID: 33382 RVA: 0x0022B754 File Offset: 0x00229954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246047, XrefRangeEnd = 246077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_Destroy_Networked_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable.NativeMethodInfoPtr_RpcReader___Server_Destroy_Networked_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008267 RID: 33383 RVA: 0x0022B7B8 File Offset: 0x002299B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_DestroyConstructableWrapper_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable.NativeMethodInfoPtr_RpcWriter___Observers_DestroyConstructableWrapper_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008268 RID: 33384 RVA: 0x0022B7EC File Offset: 0x002299EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246077, XrefRangeEnd = 246083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___DestroyConstructableWrapper_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable.NativeMethodInfoPtr_RpcLogic___DestroyConstructableWrapper_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008269 RID: 33385 RVA: 0x0022B820 File Offset: 0x00229A20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246083, XrefRangeEnd = 246090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_DestroyConstructableWrapper_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Constructable.NativeMethodInfoPtr_RpcReader___Observers_DestroyConstructableWrapper_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600826A RID: 33386 RVA: 0x0022B870 File Offset: 0x00229A70
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 246109, RefRangeEnd = 246111, XrefRangeStart = 246090, XrefRangeEnd = 246109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Constructable.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600826B RID: 33387 RVA: 0x0003DF6A File Offset: 0x0003C16A
		public Constructable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700276F RID: 10095
		// (get) Token: 0x0600826C RID: 33388 RVA: 0x0022B8AC File Offset: 0x00229AAC
		// (set) Token: 0x0600826D RID: 33389 RVA: 0x0003DF73 File Offset: 0x0003C173
		public unsafe bool isStatic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_isStatic);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_isStatic)) = value;
			}
		}

		// Token: 0x17002770 RID: 10096
		// (get) Token: 0x0600826E RID: 33390 RVA: 0x0022B8D4 File Offset: 0x00229AD4
		// (set) Token: 0x0600826F RID: 33391 RVA: 0x0003DF8E File Offset: 0x0003C18E
		public unsafe string constructableName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_constructableName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_constructableName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002771 RID: 10097
		// (get) Token: 0x06008270 RID: 33392 RVA: 0x0022B8FC File Offset: 0x00229AFC
		// (set) Token: 0x06008271 RID: 33393 RVA: 0x0003DFAD File Offset: 0x0003C1AD
		public unsafe string constructableDescription
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_constructableDescription);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_constructableDescription), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002772 RID: 10098
		// (get) Token: 0x06008272 RID: 33394 RVA: 0x0022B924 File Offset: 0x00229B24
		// (set) Token: 0x06008273 RID: 33395 RVA: 0x0003DFCC File Offset: 0x0003C1CC
		public unsafe string constructableAssetPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_constructableAssetPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_constructableAssetPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002773 RID: 10099
		// (get) Token: 0x06008274 RID: 33396 RVA: 0x0022B94C File Offset: 0x00229B4C
		// (set) Token: 0x06008275 RID: 33397 RVA: 0x0003DFEB File Offset: 0x0003C1EB
		public unsafe string ID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_ID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_ID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002774 RID: 10100
		// (get) Token: 0x06008276 RID: 33398 RVA: 0x0022B974 File Offset: 0x00229B74
		// (set) Token: 0x06008277 RID: 33399 RVA: 0x0003E00A File Offset: 0x0003C20A
		public unsafe Sprite constructableIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_constructableIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_constructableIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002775 RID: 10101
		// (get) Token: 0x06008278 RID: 33400 RVA: 0x0022B9A4 File Offset: 0x00229BA4
		// (set) Token: 0x06008279 RID: 33401 RVA: 0x0003E029 File Offset: 0x0003C229
		public unsafe BoxCollider boundingBox
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_boundingBox);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_boundingBox), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002776 RID: 10102
		// (get) Token: 0x0600827A RID: 33402 RVA: 0x0022B9D4 File Offset: 0x00229BD4
		// (set) Token: 0x0600827B RID: 33403 RVA: 0x0003E048 File Offset: 0x0003C248
		public unsafe GameObject constructionHandler_Asset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_constructionHandler_Asset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_constructionHandler_Asset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002777 RID: 10103
		// (get) Token: 0x0600827C RID: 33404 RVA: 0x0022BA04 File Offset: 0x00229C04
		// (set) Token: 0x0600827D RID: 33405 RVA: 0x0003E067 File Offset: 0x0003C267
		public unsafe List<GameObject> outlineRenderers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_outlineRenderers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_outlineRenderers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002778 RID: 10104
		// (get) Token: 0x0600827E RID: 33406 RVA: 0x0022BA34 File Offset: 0x00229C34
		// (set) Token: 0x0600827F RID: 33407 RVA: 0x0003E086 File Offset: 0x0003C286
		public unsafe Outlinable outlineEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_outlineEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Outlinable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_outlineEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002779 RID: 10105
		// (get) Token: 0x06008280 RID: 33408 RVA: 0x0022BA64 File Offset: 0x00229C64
		// (set) Token: 0x06008281 RID: 33409 RVA: 0x0003E0A5 File Offset: 0x0003C2A5
		public unsafe List<Feature> features
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_features);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Feature>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_features), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700277A RID: 10106
		// (get) Token: 0x06008282 RID: 33410 RVA: 0x0022BA94 File Offset: 0x00229C94
		// (set) Token: 0x06008283 RID: 33411 RVA: 0x0003E0C4 File Offset: 0x0003C2C4
		public unsafe bool _isVisible_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr__isVisible_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr__isVisible_k__BackingField)) = value;
			}
		}

		// Token: 0x1700277B RID: 10107
		// (get) Token: 0x06008284 RID: 33412 RVA: 0x0022BABC File Offset: 0x00229CBC
		// (set) Token: 0x06008285 RID: 33413 RVA: 0x0003E0DF File Offset: 0x0003C2DF
		public unsafe bool isDestroyed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_isDestroyed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_isDestroyed)) = value;
			}
		}

		// Token: 0x1700277C RID: 10108
		// (get) Token: 0x06008286 RID: 33414 RVA: 0x0022BAE4 File Offset: 0x00229CE4
		// (set) Token: 0x06008287 RID: 33415 RVA: 0x0003E0FA File Offset: 0x0003C2FA
		public unsafe Dictionary<Transform, LayerMask> originalLayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_originalLayers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Transform, LayerMask>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_originalLayers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700277D RID: 10109
		// (get) Token: 0x06008288 RID: 33416 RVA: 0x0022BB14 File Offset: 0x00229D14
		// (set) Token: 0x06008289 RID: 33417 RVA: 0x0003E119 File Offset: 0x0003C319
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700277E RID: 10110
		// (get) Token: 0x0600828A RID: 33418 RVA: 0x0022BB3C File Offset: 0x00229D3C
		// (set) Token: 0x0600828B RID: 33419 RVA: 0x0003E134 File Offset: 0x0003C334
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Constructable.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x0400589C RID: 22684
		private static readonly IntPtr NativeFieldInfoPtr_isStatic;

		// Token: 0x0400589D RID: 22685
		private static readonly IntPtr NativeFieldInfoPtr_constructableName;

		// Token: 0x0400589E RID: 22686
		private static readonly IntPtr NativeFieldInfoPtr_constructableDescription;

		// Token: 0x0400589F RID: 22687
		private static readonly IntPtr NativeFieldInfoPtr_constructableAssetPath;

		// Token: 0x040058A0 RID: 22688
		private static readonly IntPtr NativeFieldInfoPtr_ID;

		// Token: 0x040058A1 RID: 22689
		private static readonly IntPtr NativeFieldInfoPtr_constructableIcon;

		// Token: 0x040058A2 RID: 22690
		private static readonly IntPtr NativeFieldInfoPtr_boundingBox;

		// Token: 0x040058A3 RID: 22691
		private static readonly IntPtr NativeFieldInfoPtr_constructionHandler_Asset;

		// Token: 0x040058A4 RID: 22692
		private static readonly IntPtr NativeFieldInfoPtr_outlineRenderers;

		// Token: 0x040058A5 RID: 22693
		private static readonly IntPtr NativeFieldInfoPtr_outlineEffect;

		// Token: 0x040058A6 RID: 22694
		private static readonly IntPtr NativeFieldInfoPtr_features;

		// Token: 0x040058A7 RID: 22695
		private static readonly IntPtr NativeFieldInfoPtr__isVisible_k__BackingField;

		// Token: 0x040058A8 RID: 22696
		private static readonly IntPtr NativeFieldInfoPtr_isDestroyed;

		// Token: 0x040058A9 RID: 22697
		private static readonly IntPtr NativeFieldInfoPtr_originalLayers;

		// Token: 0x040058AA RID: 22698
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040058AB RID: 22699
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040058AC RID: 22700
		private static readonly IntPtr NativeMethodInfoPtr_get_IsStatic_Public_get_Boolean_0;

		// Token: 0x040058AD RID: 22701
		private static readonly IntPtr NativeMethodInfoPtr_get_ConstructableName_Public_get_String_0;

		// Token: 0x040058AE RID: 22702
		private static readonly IntPtr NativeMethodInfoPtr_get_ConstructableDescription_Public_get_String_0;

		// Token: 0x040058AF RID: 22703
		private static readonly IntPtr NativeMethodInfoPtr_get_ConstructableAssetPath_Public_get_String_0;

		// Token: 0x040058B0 RID: 22704
		private static readonly IntPtr NativeMethodInfoPtr_get_PrefabID_Public_get_String_0;

		// Token: 0x040058B1 RID: 22705
		private static readonly IntPtr NativeMethodInfoPtr_get_ConstructableIcon_Public_get_Sprite_0;

		// Token: 0x040058B2 RID: 22706
		private static readonly IntPtr NativeMethodInfoPtr_get__constructionHandler_Asset_Public_get_GameObject_0;

		// Token: 0x040058B3 RID: 22707
		private static readonly IntPtr NativeMethodInfoPtr_get_isVisible_Public_get_Boolean_0;

		// Token: 0x040058B4 RID: 22708
		private static readonly IntPtr NativeMethodInfoPtr_set_isVisible_Protected_set_Void_Boolean_0;

		// Token: 0x040058B5 RID: 22709
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x040058B6 RID: 22710
		private static readonly IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0;

		// Token: 0x040058B7 RID: 22711
		private static readonly IntPtr NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_New_Boolean_byref_String_0;

		// Token: 0x040058B8 RID: 22712
		private static readonly IntPtr NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_New_Boolean_0;

		// Token: 0x040058B9 RID: 22713
		private static readonly IntPtr NativeMethodInfoPtr_DestroyConstructable_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x040058BA RID: 22714
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Networked_Private_Void_0;

		// Token: 0x040058BB RID: 22715
		private static readonly IntPtr NativeMethodInfoPtr_DestroyConstructableWrapper_Private_Void_0;

		// Token: 0x040058BC RID: 22716
		private static readonly IntPtr NativeMethodInfoPtr_CanBeModified_Public_Virtual_New_Boolean_0;

		// Token: 0x040058BD RID: 22717
		private static readonly IntPtr NativeMethodInfoPtr_CanBePickedUpByHand_Public_Virtual_New_Boolean_0;

		// Token: 0x040058BE RID: 22718
		private static readonly IntPtr NativeMethodInfoPtr_CanBeSelected_Public_Virtual_New_Boolean_0;

		// Token: 0x040058BF RID: 22719
		private static readonly IntPtr NativeMethodInfoPtr_GetBuildableVersionAssetPath_Public_Virtual_New_String_0;

		// Token: 0x040058C0 RID: 22720
		private static readonly IntPtr NativeMethodInfoPtr_ShowOutline_Public_Void_EOutlineColor_0;

		// Token: 0x040058C1 RID: 22721
		private static readonly IntPtr NativeMethodInfoPtr_HideOutline_Public_Void_0;

		// Token: 0x040058C2 RID: 22722
		private static readonly IntPtr NativeMethodInfoPtr_GetCosmeticCenter_Public_Virtual_New_Vector3_0;

		// Token: 0x040058C3 RID: 22723
		private static readonly IntPtr NativeMethodInfoPtr_GetBoundingBoxLongestSide_Public_Single_0;

		// Token: 0x040058C4 RID: 22724
		private static readonly IntPtr NativeMethodInfoPtr_SetInvisible_Public_Virtual_New_Void_0;

		// Token: 0x040058C5 RID: 22725
		private static readonly IntPtr NativeMethodInfoPtr_RestoreVisibility_Public_Virtual_New_Void_0;

		// Token: 0x040058C6 RID: 22726
		private static readonly IntPtr NativeMethodInfoPtr_SetLayerRecursively_Public_Void_GameObject_Int32_0;

		// Token: 0x040058C7 RID: 22727
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040058C8 RID: 22728
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040058C9 RID: 22729
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040058CA RID: 22730
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040058CB RID: 22731
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_Destroy_Networked_2166136261_Private_Void_0;

		// Token: 0x040058CC RID: 22732
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Destroy_Networked_2166136261_Private_Void_0;

		// Token: 0x040058CD RID: 22733
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_Destroy_Networked_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040058CE RID: 22734
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_DestroyConstructableWrapper_2166136261_Private_Void_0;

		// Token: 0x040058CF RID: 22735
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___DestroyConstructableWrapper_2166136261_Private_Void_0;

		// Token: 0x040058D0 RID: 22736
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_DestroyConstructableWrapper_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x040058D1 RID: 22737
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;
	}
}
