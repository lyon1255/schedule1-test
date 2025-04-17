using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ConstructableScripts;
using Il2CppScheduleOne.DevUtilities;
using UnityEngine;

namespace Il2CppScheduleOne.Misc
{
	// Token: 0x0200076C RID: 1900
	public class ToggleableLight : MonoBehaviour
	{
		// Token: 0x0600B46E RID: 46190 RVA: 0x002CECDC File Offset: 0x002CCEDC
		// Note: this type is marked as 'beforefieldinit'.
		static ToggleableLight()
		{
			Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Misc", "ToggleableLight");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr);
			ToggleableLight.NativeFieldInfoPtr_isOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr, "isOn");
			ToggleableLight.NativeFieldInfoPtr_lightSources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr, "lightSources");
			ToggleableLight.NativeFieldInfoPtr_lightSurfacesMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr, "lightSurfacesMeshes");
			ToggleableLight.NativeFieldInfoPtr_MaterialIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr, "MaterialIndex");
			ToggleableLight.NativeFieldInfoPtr_lightOnMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr, "lightOnMat");
			ToggleableLight.NativeFieldInfoPtr_lightOffMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr, "lightOffMat");
			ToggleableLight.NativeFieldInfoPtr_constructable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr, "constructable");
			ToggleableLight.NativeFieldInfoPtr_lightsApplied = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr, "lightsApplied");
			ToggleableLight.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr, 100685508);
			ToggleableLight.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr, 100685509);
			ToggleableLight.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr, 100685510);
			ToggleableLight.NativeMethodInfoPtr_TurnOn_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr, 100685511);
			ToggleableLight.NativeMethodInfoPtr_TurnOff_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr, 100685512);
			ToggleableLight.NativeMethodInfoPtr_SetLights_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr, 100685513);
			ToggleableLight.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr, 100685514);
		}

		// Token: 0x0600B46F RID: 46191 RVA: 0x002CEE38 File Offset: 0x002CD038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309270, XrefRangeEnd = 309274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ToggleableLight.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B470 RID: 46192 RVA: 0x002CEE74 File Offset: 0x002CD074
		[CallerCount(0)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableLight.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B471 RID: 46193 RVA: 0x002CEEA8 File Offset: 0x002CD0A8
		[CallerCount(0)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ToggleableLight.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B472 RID: 46194 RVA: 0x002CEEE4 File Offset: 0x002CD0E4
		[CallerCount(0)]
		public unsafe void TurnOn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableLight.NativeMethodInfoPtr_TurnOn_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B473 RID: 46195 RVA: 0x002CEF18 File Offset: 0x002CD118
		[CallerCount(0)]
		public unsafe void TurnOff()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableLight.NativeMethodInfoPtr_TurnOff_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B474 RID: 46196 RVA: 0x002CEF4C File Offset: 0x002CD14C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309274, XrefRangeEnd = 309288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetLights(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ToggleableLight.NativeMethodInfoPtr_SetLights_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B475 RID: 46197 RVA: 0x002CEF98 File Offset: 0x002CD198
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ToggleableLight() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ToggleableLight>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableLight.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B476 RID: 46198 RVA: 0x000587D3 File Offset: 0x000569D3
		public ToggleableLight(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170037EF RID: 14319
		// (get) Token: 0x0600B477 RID: 46199 RVA: 0x002CEFD4 File Offset: 0x002CD1D4
		// (set) Token: 0x0600B478 RID: 46200 RVA: 0x000587DC File Offset: 0x000569DC
		public unsafe bool isOn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLight.NativeFieldInfoPtr_isOn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLight.NativeFieldInfoPtr_isOn)) = value;
			}
		}

		// Token: 0x170037F0 RID: 14320
		// (get) Token: 0x0600B479 RID: 46201 RVA: 0x002CEFFC File Offset: 0x002CD1FC
		// (set) Token: 0x0600B47A RID: 46202 RVA: 0x000587F7 File Offset: 0x000569F7
		public unsafe Il2CppReferenceArray<OptimizedLight> lightSources
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLight.NativeFieldInfoPtr_lightSources);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<OptimizedLight>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLight.NativeFieldInfoPtr_lightSources), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037F1 RID: 14321
		// (get) Token: 0x0600B47B RID: 46203 RVA: 0x002CF02C File Offset: 0x002CD22C
		// (set) Token: 0x0600B47C RID: 46204 RVA: 0x00058816 File Offset: 0x00056A16
		public unsafe Il2CppReferenceArray<MeshRenderer> lightSurfacesMeshes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLight.NativeFieldInfoPtr_lightSurfacesMeshes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLight.NativeFieldInfoPtr_lightSurfacesMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037F2 RID: 14322
		// (get) Token: 0x0600B47D RID: 46205 RVA: 0x002CF05C File Offset: 0x002CD25C
		// (set) Token: 0x0600B47E RID: 46206 RVA: 0x00058835 File Offset: 0x00056A35
		public unsafe int MaterialIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLight.NativeFieldInfoPtr_MaterialIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLight.NativeFieldInfoPtr_MaterialIndex)) = value;
			}
		}

		// Token: 0x170037F3 RID: 14323
		// (get) Token: 0x0600B47F RID: 46207 RVA: 0x002CF084 File Offset: 0x002CD284
		// (set) Token: 0x0600B480 RID: 46208 RVA: 0x00058850 File Offset: 0x00056A50
		public unsafe Material lightOnMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLight.NativeFieldInfoPtr_lightOnMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLight.NativeFieldInfoPtr_lightOnMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037F4 RID: 14324
		// (get) Token: 0x0600B481 RID: 46209 RVA: 0x002CF0B4 File Offset: 0x002CD2B4
		// (set) Token: 0x0600B482 RID: 46210 RVA: 0x0005886F File Offset: 0x00056A6F
		public unsafe Material lightOffMat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLight.NativeFieldInfoPtr_lightOffMat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLight.NativeFieldInfoPtr_lightOffMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037F5 RID: 14325
		// (get) Token: 0x0600B483 RID: 46211 RVA: 0x002CF0E4 File Offset: 0x002CD2E4
		// (set) Token: 0x0600B484 RID: 46212 RVA: 0x0005888E File Offset: 0x00056A8E
		public unsafe Constructable_GridBased constructable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLight.NativeFieldInfoPtr_constructable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Constructable_GridBased>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLight.NativeFieldInfoPtr_constructable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037F6 RID: 14326
		// (get) Token: 0x0600B485 RID: 46213 RVA: 0x002CF114 File Offset: 0x002CD314
		// (set) Token: 0x0600B486 RID: 46214 RVA: 0x000588AD File Offset: 0x00056AAD
		public unsafe bool lightsApplied
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLight.NativeFieldInfoPtr_lightsApplied);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableLight.NativeFieldInfoPtr_lightsApplied)) = value;
			}
		}

		// Token: 0x040079A3 RID: 31139
		private static readonly IntPtr NativeFieldInfoPtr_isOn;

		// Token: 0x040079A4 RID: 31140
		private static readonly IntPtr NativeFieldInfoPtr_lightSources;

		// Token: 0x040079A5 RID: 31141
		private static readonly IntPtr NativeFieldInfoPtr_lightSurfacesMeshes;

		// Token: 0x040079A6 RID: 31142
		private static readonly IntPtr NativeFieldInfoPtr_MaterialIndex;

		// Token: 0x040079A7 RID: 31143
		private static readonly IntPtr NativeFieldInfoPtr_lightOnMat;

		// Token: 0x040079A8 RID: 31144
		private static readonly IntPtr NativeFieldInfoPtr_lightOffMat;

		// Token: 0x040079A9 RID: 31145
		private static readonly IntPtr NativeFieldInfoPtr_constructable;

		// Token: 0x040079AA RID: 31146
		private static readonly IntPtr NativeFieldInfoPtr_lightsApplied;

		// Token: 0x040079AB RID: 31147
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x040079AC RID: 31148
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x040079AD RID: 31149
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x040079AE RID: 31150
		private static readonly IntPtr NativeMethodInfoPtr_TurnOn_Public_Void_0;

		// Token: 0x040079AF RID: 31151
		private static readonly IntPtr NativeMethodInfoPtr_TurnOff_Public_Void_0;

		// Token: 0x040079B0 RID: 31152
		private static readonly IntPtr NativeMethodInfoPtr_SetLights_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x040079B1 RID: 31153
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
