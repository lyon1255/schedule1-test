using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.Vision;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Linq;
using UnityEngine;

namespace Il2CppScheduleOne.Stealth
{
	// Token: 0x020001A4 RID: 420
	public class PlayerVisibility : NetworkBehaviour
	{
		// Token: 0x06002253 RID: 8787 RVA: 0x000DBCCC File Offset: 0x000D9ECC
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerVisibility()
		{
			Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Stealth", "PlayerVisibility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr);
			PlayerVisibility.NativeFieldInfoPtr_MAX_VISIBLITY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, "MAX_VISIBLITY");
			PlayerVisibility.NativeFieldInfoPtr_CurrentVisibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, "CurrentVisibility");
			PlayerVisibility.NativeFieldInfoPtr_activeAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, "activeAttributes");
			PlayerVisibility.NativeFieldInfoPtr_filteredAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, "filteredAttributes");
			PlayerVisibility.NativeFieldInfoPtr_visibilityCheckMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, "visibilityCheckMask");
			PlayerVisibility.NativeFieldInfoPtr_visibilityPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, "visibilityPoints");
			PlayerVisibility.NativeFieldInfoPtr_environmentalVisibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, "environmentalVisibility");
			PlayerVisibility.NativeFieldInfoPtr__HighestVisionEvent_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, "<HighestVisionEvent>k__BackingField");
			PlayerVisibility.NativeFieldInfoPtr_hits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, "hits");
			PlayerVisibility.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Stealth.PlayerVisibilityAssembly-CSharp.dll_Excuted");
			PlayerVisibility.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Stealth.PlayerVisibilityAssembly-CSharp.dll_Excuted");
			PlayerVisibility.NativeMethodInfoPtr_get_HighestVisionEvent_Public_get_VisionEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, 100667167);
			PlayerVisibility.NativeMethodInfoPtr_set_HighestVisionEvent_Public_set_Void_VisionEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, 100667168);
			PlayerVisibility.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, 100667169);
			PlayerVisibility.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, 100667170);
			PlayerVisibility.NativeMethodInfoPtr_CalculateVisibility_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, 100667171);
			PlayerVisibility.NativeMethodInfoPtr_GetAttribute_Public_VisibilityAttribute_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, 100667172);
			PlayerVisibility.NativeMethodInfoPtr_UpdateEnvironmentalVisibilityAttribute_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, 100667173);
			PlayerVisibility.NativeMethodInfoPtr_CalculateExposureToPoint_Public_Single_Vector3_Single_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, 100667174);
			PlayerVisibility.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, 100667175);
			PlayerVisibility.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, 100667176);
			PlayerVisibility.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, 100667177);
			PlayerVisibility.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, 100667178);
			PlayerVisibility.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, 100667179);
		}

		// Token: 0x17000BCA RID: 3018
		// (get) Token: 0x06002254 RID: 8788 RVA: 0x000DBEDC File Offset: 0x000DA0DC
		// (set) Token: 0x06002255 RID: 8789 RVA: 0x000DBF1C File Offset: 0x000DA11C
		public unsafe VisionEvent HighestVisionEvent
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 93781, RefRangeEnd = 93782, XrefRangeStart = 93781, XrefRangeEnd = 93782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisibility.NativeMethodInfoPtr_get_HighestVisionEvent_Public_get_VisionEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisionEvent>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111470, XrefRangeEnd = 111471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisibility.NativeMethodInfoPtr_set_HighestVisionEvent_Public_set_Void_VisionEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002256 RID: 8790 RVA: 0x000DBF60 File Offset: 0x000DA160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111471, XrefRangeEnd = 111480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerVisibility.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002257 RID: 8791 RVA: 0x000DBF9C File Offset: 0x000DA19C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111480, XrefRangeEnd = 111486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisibility.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002258 RID: 8792 RVA: 0x000DBFD0 File Offset: 0x000DA1D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 111581, RefRangeEnd = 111582, XrefRangeStart = 111486, XrefRangeEnd = 111581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float CalculateVisibility()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisibility.NativeMethodInfoPtr_CalculateVisibility_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002259 RID: 8793 RVA: 0x000DC00C File Offset: 0x000DA20C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 111597, RefRangeEnd = 111598, XrefRangeStart = 111582, XrefRangeEnd = 111597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisibilityAttribute GetAttribute(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisibility.NativeMethodInfoPtr_GetAttribute_Public_VisibilityAttribute_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisibilityAttribute>(intPtr3) : null;
		}

		// Token: 0x0600225A RID: 8794 RVA: 0x000DC05C File Offset: 0x000DA25C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111598, XrefRangeEnd = 111603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateEnvironmentalVisibilityAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisibility.NativeMethodInfoPtr_UpdateEnvironmentalVisibilityAttribute_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600225B RID: 8795 RVA: 0x000DC090 File Offset: 0x000DA290
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 111721, RefRangeEnd = 111723, XrefRangeStart = 111603, XrefRangeEnd = 111721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float CalculateExposureToPoint(Vector3 point, float checkRange = 50f, NPC checkingNPC = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkRange;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(checkingNPC);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisibility.NativeMethodInfoPtr_CalculateExposureToPoint_Public_Single_Vector3_Single_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600225C RID: 8796 RVA: 0x000DC0FC File Offset: 0x000DA2FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111723, XrefRangeEnd = 111743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerVisibility() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisibility.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600225D RID: 8797 RVA: 0x000DC138 File Offset: 0x000DA338
		[CallerCount(0)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerVisibility.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600225E RID: 8798 RVA: 0x000DC174 File Offset: 0x000DA374
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerVisibility.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600225F RID: 8799 RVA: 0x000DC1B0 File Offset: 0x000DA3B0
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerVisibility.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002260 RID: 8800 RVA: 0x000DC1EC File Offset: 0x000DA3EC
		[CallerCount(0)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerVisibility.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002261 RID: 8801 RVA: 0x00013274 File Offset: 0x00011474
		public PlayerVisibility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000BBF RID: 3007
		// (get) Token: 0x06002262 RID: 8802 RVA: 0x000DC228 File Offset: 0x000DA428
		// (set) Token: 0x06002263 RID: 8803 RVA: 0x0001327D File Offset: 0x0001147D
		public unsafe static float MAX_VISIBLITY
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PlayerVisibility.NativeFieldInfoPtr_MAX_VISIBLITY, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerVisibility.NativeFieldInfoPtr_MAX_VISIBLITY, (void*)(&value));
			}
		}

		// Token: 0x17000BC0 RID: 3008
		// (get) Token: 0x06002264 RID: 8804 RVA: 0x000DC244 File Offset: 0x000DA444
		// (set) Token: 0x06002265 RID: 8805 RVA: 0x0001328B File Offset: 0x0001148B
		public unsafe float CurrentVisibility
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr_CurrentVisibility);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr_CurrentVisibility)) = value;
			}
		}

		// Token: 0x17000BC1 RID: 3009
		// (get) Token: 0x06002266 RID: 8806 RVA: 0x000DC26C File Offset: 0x000DA46C
		// (set) Token: 0x06002267 RID: 8807 RVA: 0x000132A6 File Offset: 0x000114A6
		public unsafe List<VisibilityAttribute> activeAttributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr_activeAttributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VisibilityAttribute>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr_activeAttributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BC2 RID: 3010
		// (get) Token: 0x06002268 RID: 8808 RVA: 0x000DC29C File Offset: 0x000DA49C
		// (set) Token: 0x06002269 RID: 8809 RVA: 0x000132C5 File Offset: 0x000114C5
		public unsafe List<VisibilityAttribute> filteredAttributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr_filteredAttributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VisibilityAttribute>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr_filteredAttributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BC3 RID: 3011
		// (get) Token: 0x0600226A RID: 8810 RVA: 0x000DC2CC File Offset: 0x000DA4CC
		// (set) Token: 0x0600226B RID: 8811 RVA: 0x000132E4 File Offset: 0x000114E4
		public unsafe LayerMask visibilityCheckMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr_visibilityCheckMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr_visibilityCheckMask)) = value;
			}
		}

		// Token: 0x17000BC4 RID: 3012
		// (get) Token: 0x0600226C RID: 8812 RVA: 0x000DC2F4 File Offset: 0x000DA4F4
		// (set) Token: 0x0600226D RID: 8813 RVA: 0x000132FF File Offset: 0x000114FF
		public unsafe List<Transform> visibilityPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr_visibilityPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr_visibilityPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BC5 RID: 3013
		// (get) Token: 0x0600226E RID: 8814 RVA: 0x000DC324 File Offset: 0x000DA524
		// (set) Token: 0x0600226F RID: 8815 RVA: 0x0001331E File Offset: 0x0001151E
		public unsafe VisibilityAttribute environmentalVisibility
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr_environmentalVisibility);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisibilityAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr_environmentalVisibility), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BC6 RID: 3014
		// (get) Token: 0x06002270 RID: 8816 RVA: 0x000DC354 File Offset: 0x000DA554
		// (set) Token: 0x06002271 RID: 8817 RVA: 0x0001333D File Offset: 0x0001153D
		public unsafe VisionEvent _HighestVisionEvent_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr__HighestVisionEvent_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisionEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr__HighestVisionEvent_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BC7 RID: 3015
		// (get) Token: 0x06002272 RID: 8818 RVA: 0x000DC384 File Offset: 0x000DA584
		// (set) Token: 0x06002273 RID: 8819 RVA: 0x0001335C File Offset: 0x0001155C
		public unsafe List<RaycastHit> hits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr_hits);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RaycastHit>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr_hits), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BC8 RID: 3016
		// (get) Token: 0x06002274 RID: 8820 RVA: 0x000DC3B4 File Offset: 0x000DA5B4
		// (set) Token: 0x06002275 RID: 8821 RVA: 0x0001337B File Offset: 0x0001157B
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17000BC9 RID: 3017
		// (get) Token: 0x06002276 RID: 8822 RVA: 0x000DC3DC File Offset: 0x000DA5DC
		// (set) Token: 0x06002277 RID: 8823 RVA: 0x00013396 File Offset: 0x00011596
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040016DA RID: 5850
		private static readonly IntPtr NativeFieldInfoPtr_MAX_VISIBLITY;

		// Token: 0x040016DB RID: 5851
		private static readonly IntPtr NativeFieldInfoPtr_CurrentVisibility;

		// Token: 0x040016DC RID: 5852
		private static readonly IntPtr NativeFieldInfoPtr_activeAttributes;

		// Token: 0x040016DD RID: 5853
		private static readonly IntPtr NativeFieldInfoPtr_filteredAttributes;

		// Token: 0x040016DE RID: 5854
		private static readonly IntPtr NativeFieldInfoPtr_visibilityCheckMask;

		// Token: 0x040016DF RID: 5855
		private static readonly IntPtr NativeFieldInfoPtr_visibilityPoints;

		// Token: 0x040016E0 RID: 5856
		private static readonly IntPtr NativeFieldInfoPtr_environmentalVisibility;

		// Token: 0x040016E1 RID: 5857
		private static readonly IntPtr NativeFieldInfoPtr__HighestVisionEvent_k__BackingField;

		// Token: 0x040016E2 RID: 5858
		private static readonly IntPtr NativeFieldInfoPtr_hits;

		// Token: 0x040016E3 RID: 5859
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040016E4 RID: 5860
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040016E5 RID: 5861
		private static readonly IntPtr NativeMethodInfoPtr_get_HighestVisionEvent_Public_get_VisionEvent_0;

		// Token: 0x040016E6 RID: 5862
		private static readonly IntPtr NativeMethodInfoPtr_set_HighestVisionEvent_Public_set_Void_VisionEvent_0;

		// Token: 0x040016E7 RID: 5863
		private static readonly IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0;

		// Token: 0x040016E8 RID: 5864
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x040016E9 RID: 5865
		private static readonly IntPtr NativeMethodInfoPtr_CalculateVisibility_Private_Single_0;

		// Token: 0x040016EA RID: 5866
		private static readonly IntPtr NativeMethodInfoPtr_GetAttribute_Public_VisibilityAttribute_String_0;

		// Token: 0x040016EB RID: 5867
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEnvironmentalVisibilityAttribute_Private_Void_0;

		// Token: 0x040016EC RID: 5868
		private static readonly IntPtr NativeMethodInfoPtr_CalculateExposureToPoint_Public_Single_Vector3_Single_NPC_0;

		// Token: 0x040016ED RID: 5869
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040016EE RID: 5870
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040016EF RID: 5871
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040016F0 RID: 5872
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040016F1 RID: 5873
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x020008C4 RID: 2244
		[ObfuscatedName("ScheduleOne.Stealth.PlayerVisibility+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600C3A0 RID: 50080 RVA: 0x002FB2A8 File Offset: 0x002F94A8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PlayerVisibility.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerVisibility.__c>.NativeClassPtr);
				PlayerVisibility.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisibility.__c>.NativeClassPtr, "<>9");
				PlayerVisibility.__c.NativeFieldInfoPtr___9__13_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisibility.__c>.NativeClassPtr, "<>9__13_0");
				PlayerVisibility.__c.NativeFieldInfoPtr___9__13_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisibility.__c>.NativeClassPtr, "<>9__13_1");
				PlayerVisibility.__c.NativeFieldInfoPtr___9__13_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisibility.__c>.NativeClassPtr, "<>9__13_2");
				PlayerVisibility.__c.NativeFieldInfoPtr___9__13_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisibility.__c>.NativeClassPtr, "<>9__13_5");
				PlayerVisibility.__c.NativeFieldInfoPtr___9__13_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisibility.__c>.NativeClassPtr, "<>9__13_3");
				PlayerVisibility.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility.__c>.NativeClassPtr, 100667181);
				PlayerVisibility.__c.NativeMethodInfoPtr__CalculateVisibility_b__13_0_Internal_Boolean_VisibilityAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility.__c>.NativeClassPtr, 100667182);
				PlayerVisibility.__c.NativeMethodInfoPtr__CalculateVisibility_b__13_1_Internal_String_UniqueVisibilityAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility.__c>.NativeClassPtr, 100667183);
				PlayerVisibility.__c.NativeMethodInfoPtr__CalculateVisibility_b__13_2_Internal_String_IGrouping_2_String_UniqueVisibilityAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility.__c>.NativeClassPtr, 100667184);
				PlayerVisibility.__c.NativeMethodInfoPtr__CalculateVisibility_b__13_3_Internal_Single_IGrouping_2_String_UniqueVisibilityAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility.__c>.NativeClassPtr, 100667185);
				PlayerVisibility.__c.NativeMethodInfoPtr__CalculateVisibility_b__13_5_Internal_Single_UniqueVisibilityAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility.__c>.NativeClassPtr, 100667186);
			}

			// Token: 0x0600C3A1 RID: 50081 RVA: 0x002FB3C4 File Offset: 0x002F95C4
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerVisibility.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisibility.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C3A2 RID: 50082 RVA: 0x002FB400 File Offset: 0x002F9600
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111438, XrefRangeEnd = 111439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CalculateVisibility_b__13_0(VisibilityAttribute a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisibility.__c.NativeMethodInfoPtr__CalculateVisibility_b__13_0_Internal_Boolean_VisibilityAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C3A3 RID: 50083 RVA: 0x002FB450 File Offset: 0x002F9650
			[CallerCount(0)]
			public unsafe string _CalculateVisibility_b__13_1(UniqueVisibilityAttribute uva)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uva);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisibility.__c.NativeMethodInfoPtr__CalculateVisibility_b__13_1_Internal_String_UniqueVisibilityAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600C3A4 RID: 50084 RVA: 0x002FB498 File Offset: 0x002F9698
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111439, XrefRangeEnd = 111443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _CalculateVisibility_b__13_2(IGrouping<string, UniqueVisibilityAttribute> group)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisibility.__c.NativeMethodInfoPtr__CalculateVisibility_b__13_2_Internal_String_IGrouping_2_String_UniqueVisibilityAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600C3A5 RID: 50085 RVA: 0x002FB4E0 File Offset: 0x002F96E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111443, XrefRangeEnd = 111461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _CalculateVisibility_b__13_3(IGrouping<string, UniqueVisibilityAttribute> group)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisibility.__c.NativeMethodInfoPtr__CalculateVisibility_b__13_3_Internal_Single_IGrouping_2_String_UniqueVisibilityAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C3A6 RID: 50086 RVA: 0x002FB530 File Offset: 0x002F9730
			[CallerCount(0)]
			public unsafe float _CalculateVisibility_b__13_5(UniqueVisibilityAttribute uva)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uva);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisibility.__c.NativeMethodInfoPtr__CalculateVisibility_b__13_5_Internal_Single_UniqueVisibilityAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C3A7 RID: 50087 RVA: 0x0005F3B0 File Offset: 0x0005D5B0
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D15 RID: 15637
			// (get) Token: 0x0600C3A8 RID: 50088 RVA: 0x002FB580 File Offset: 0x002F9780
			// (set) Token: 0x0600C3A9 RID: 50089 RVA: 0x0005F3B9 File Offset: 0x0005D5B9
			public unsafe static PlayerVisibility.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerVisibility.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerVisibility.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerVisibility.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D16 RID: 15638
			// (get) Token: 0x0600C3AA RID: 50090 RVA: 0x002FB5A8 File Offset: 0x002F97A8
			// (set) Token: 0x0600C3AB RID: 50091 RVA: 0x0005F3CB File Offset: 0x0005D5CB
			public unsafe static Func<VisibilityAttribute, bool> __9__13_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerVisibility.__c.NativeFieldInfoPtr___9__13_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<VisibilityAttribute, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerVisibility.__c.NativeFieldInfoPtr___9__13_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D17 RID: 15639
			// (get) Token: 0x0600C3AC RID: 50092 RVA: 0x002FB5D0 File Offset: 0x002F97D0
			// (set) Token: 0x0600C3AD RID: 50093 RVA: 0x0005F3DD File Offset: 0x0005D5DD
			public unsafe static Func<UniqueVisibilityAttribute, string> __9__13_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerVisibility.__c.NativeFieldInfoPtr___9__13_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<UniqueVisibilityAttribute, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerVisibility.__c.NativeFieldInfoPtr___9__13_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D18 RID: 15640
			// (get) Token: 0x0600C3AE RID: 50094 RVA: 0x002FB5F8 File Offset: 0x002F97F8
			// (set) Token: 0x0600C3AF RID: 50095 RVA: 0x0005F3EF File Offset: 0x0005D5EF
			public unsafe static Func<IGrouping<string, UniqueVisibilityAttribute>, string> __9__13_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerVisibility.__c.NativeFieldInfoPtr___9__13_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IGrouping<string, UniqueVisibilityAttribute>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerVisibility.__c.NativeFieldInfoPtr___9__13_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D19 RID: 15641
			// (get) Token: 0x0600C3B0 RID: 50096 RVA: 0x002FB620 File Offset: 0x002F9820
			// (set) Token: 0x0600C3B1 RID: 50097 RVA: 0x0005F401 File Offset: 0x0005D601
			public unsafe static Func<UniqueVisibilityAttribute, float> __9__13_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerVisibility.__c.NativeFieldInfoPtr___9__13_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<UniqueVisibilityAttribute, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerVisibility.__c.NativeFieldInfoPtr___9__13_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D1A RID: 15642
			// (get) Token: 0x0600C3B2 RID: 50098 RVA: 0x002FB648 File Offset: 0x002F9848
			// (set) Token: 0x0600C3B3 RID: 50099 RVA: 0x0005F413 File Offset: 0x0005D613
			public unsafe static Func<IGrouping<string, UniqueVisibilityAttribute>, float> __9__13_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerVisibility.__c.NativeFieldInfoPtr___9__13_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IGrouping<string, UniqueVisibilityAttribute>, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerVisibility.__c.NativeFieldInfoPtr___9__13_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040084A1 RID: 33953
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040084A2 RID: 33954
			private static readonly IntPtr NativeFieldInfoPtr___9__13_0;

			// Token: 0x040084A3 RID: 33955
			private static readonly IntPtr NativeFieldInfoPtr___9__13_1;

			// Token: 0x040084A4 RID: 33956
			private static readonly IntPtr NativeFieldInfoPtr___9__13_2;

			// Token: 0x040084A5 RID: 33957
			private static readonly IntPtr NativeFieldInfoPtr___9__13_5;

			// Token: 0x040084A6 RID: 33958
			private static readonly IntPtr NativeFieldInfoPtr___9__13_3;

			// Token: 0x040084A7 RID: 33959
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040084A8 RID: 33960
			private static readonly IntPtr NativeMethodInfoPtr__CalculateVisibility_b__13_0_Internal_Boolean_VisibilityAttribute_0;

			// Token: 0x040084A9 RID: 33961
			private static readonly IntPtr NativeMethodInfoPtr__CalculateVisibility_b__13_1_Internal_String_UniqueVisibilityAttribute_0;

			// Token: 0x040084AA RID: 33962
			private static readonly IntPtr NativeMethodInfoPtr__CalculateVisibility_b__13_2_Internal_String_IGrouping_2_String_UniqueVisibilityAttribute_0;

			// Token: 0x040084AB RID: 33963
			private static readonly IntPtr NativeMethodInfoPtr__CalculateVisibility_b__13_3_Internal_Single_IGrouping_2_String_UniqueVisibilityAttribute_0;

			// Token: 0x040084AC RID: 33964
			private static readonly IntPtr NativeMethodInfoPtr__CalculateVisibility_b__13_5_Internal_Single_UniqueVisibilityAttribute_0;
		}

		// Token: 0x020008C5 RID: 2245
		[ObfuscatedName("ScheduleOne.Stealth.PlayerVisibility+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C3B4 RID: 50100 RVA: 0x002FB670 File Offset: 0x002F9870
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<PlayerVisibility.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerVisibility.__c__DisplayClass13_0>.NativeClassPtr);
				PlayerVisibility.__c__DisplayClass13_0.NativeFieldInfoPtr_maxPointsChangesByUniquenessCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisibility.__c__DisplayClass13_0>.NativeClassPtr, "maxPointsChangesByUniquenessCode");
				PlayerVisibility.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility.__c__DisplayClass13_0>.NativeClassPtr, 100667187);
				PlayerVisibility.__c__DisplayClass13_0.NativeMethodInfoPtr__CalculateVisibility_b__4_Internal_Boolean_VisibilityAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility.__c__DisplayClass13_0>.NativeClassPtr, 100667188);
			}

			// Token: 0x0600C3B5 RID: 50101 RVA: 0x002FB6D8 File Offset: 0x002F98D8
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerVisibility.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisibility.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C3B6 RID: 50102 RVA: 0x002FB714 File Offset: 0x002F9914
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111461, XrefRangeEnd = 111466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CalculateVisibility_b__4(VisibilityAttribute attr)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisibility.__c__DisplayClass13_0.NativeMethodInfoPtr__CalculateVisibility_b__4_Internal_Boolean_VisibilityAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C3B7 RID: 50103 RVA: 0x0005F425 File Offset: 0x0005D625
			public __c__DisplayClass13_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D1B RID: 15643
			// (get) Token: 0x0600C3B8 RID: 50104 RVA: 0x002FB764 File Offset: 0x002F9964
			// (set) Token: 0x0600C3B9 RID: 50105 RVA: 0x0005F42E File Offset: 0x0005D62E
			public unsafe Dictionary<string, float> maxPointsChangesByUniquenessCode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.__c__DisplayClass13_0.NativeFieldInfoPtr_maxPointsChangesByUniquenessCode);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.__c__DisplayClass13_0.NativeFieldInfoPtr_maxPointsChangesByUniquenessCode), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040084AD RID: 33965
			private static readonly IntPtr NativeFieldInfoPtr_maxPointsChangesByUniquenessCode;

			// Token: 0x040084AE RID: 33966
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040084AF RID: 33967
			private static readonly IntPtr NativeMethodInfoPtr__CalculateVisibility_b__4_Internal_Boolean_VisibilityAttribute_0;
		}

		// Token: 0x020008C6 RID: 2246
		[ObfuscatedName("ScheduleOne.Stealth.PlayerVisibility+<>c__DisplayClass14_0")]
		public sealed class __c__DisplayClass14_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C3BA RID: 50106 RVA: 0x002FB794 File Offset: 0x002F9994
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_0()
			{
				Il2CppClassPointerStore<PlayerVisibility.__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerVisibility>.NativeClassPtr, "<>c__DisplayClass14_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerVisibility.__c__DisplayClass14_0>.NativeClassPtr);
				PlayerVisibility.__c__DisplayClass14_0.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerVisibility.__c__DisplayClass14_0>.NativeClassPtr, "name");
				PlayerVisibility.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility.__c__DisplayClass14_0>.NativeClassPtr, 100667189);
				PlayerVisibility.__c__DisplayClass14_0.NativeMethodInfoPtr__GetAttribute_b__0_Internal_Boolean_VisibilityAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerVisibility.__c__DisplayClass14_0>.NativeClassPtr, 100667190);
			}

			// Token: 0x0600C3BB RID: 50107 RVA: 0x002FB7FC File Offset: 0x002F99FC
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerVisibility.__c__DisplayClass14_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisibility.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C3BC RID: 50108 RVA: 0x002FB838 File Offset: 0x002F9A38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 111466, XrefRangeEnd = 111470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetAttribute_b__0(VisibilityAttribute x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerVisibility.__c__DisplayClass14_0.NativeMethodInfoPtr__GetAttribute_b__0_Internal_Boolean_VisibilityAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C3BD RID: 50109 RVA: 0x0005F44D File Offset: 0x0005D64D
			public __c__DisplayClass14_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D1C RID: 15644
			// (get) Token: 0x0600C3BE RID: 50110 RVA: 0x002FB888 File Offset: 0x002F9A88
			// (set) Token: 0x0600C3BF RID: 50111 RVA: 0x0005F456 File Offset: 0x0005D656
			public unsafe string name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.__c__DisplayClass14_0.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerVisibility.__c__DisplayClass14_0.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040084B0 RID: 33968
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x040084B1 RID: 33969
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040084B2 RID: 33970
			private static readonly IntPtr NativeMethodInfoPtr__GetAttribute_b__0_Internal_Boolean_VisibilityAttribute_0;
		}
	}
}
