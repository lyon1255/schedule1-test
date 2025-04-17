using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.UI;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.TV
{
	// Token: 0x0200018D RID: 397
	public class TVApp : MonoBehaviour
	{
		// Token: 0x0600203A RID: 8250 RVA: 0x000D4B50 File Offset: 0x000D2D50
		// Note: this type is marked as 'beforefieldinit'.
		static TVApp()
		{
			Il2CppClassPointerStore<TVApp>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.TV", "TVApp");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TVApp>.NativeClassPtr);
			TVApp.NativeFieldInfoPtr_SCALE_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVApp>.NativeClassPtr, "SCALE_MIN");
			TVApp.NativeFieldInfoPtr_SCALE_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVApp>.NativeClassPtr, "SCALE_MAX");
			TVApp.NativeFieldInfoPtr_LERP_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVApp>.NativeClassPtr, "LERP_TIME");
			TVApp.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVApp>.NativeClassPtr, "<IsOpen>k__BackingField");
			TVApp.NativeFieldInfoPtr_CanClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVApp>.NativeClassPtr, "CanClose");
			TVApp.NativeFieldInfoPtr_AppName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVApp>.NativeClassPtr, "AppName");
			TVApp.NativeFieldInfoPtr_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVApp>.NativeClassPtr, "Icon");
			TVApp.NativeFieldInfoPtr_Pauseable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVApp>.NativeClassPtr, "Pauseable");
			TVApp.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVApp>.NativeClassPtr, "Canvas");
			TVApp.NativeFieldInfoPtr_PreviousScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVApp>.NativeClassPtr, "PreviousScreen");
			TVApp.NativeFieldInfoPtr_CanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVApp>.NativeClassPtr, "CanvasGroup");
			TVApp.NativeFieldInfoPtr_PauseScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVApp>.NativeClassPtr, "PauseScreen");
			TVApp.NativeFieldInfoPtr_lerpCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVApp>.NativeClassPtr, "lerpCoroutine");
			TVApp.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVApp>.NativeClassPtr, 100666894);
			TVApp.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVApp>.NativeClassPtr, 100666895);
			TVApp.NativeMethodInfoPtr_get_IsPaused_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVApp>.NativeClassPtr, 100666896);
			TVApp.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVApp>.NativeClassPtr, 100666897);
			TVApp.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVApp>.NativeClassPtr, 100666898);
			TVApp.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVApp>.NativeClassPtr, 100666899);
			TVApp.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVApp>.NativeClassPtr, 100666900);
			TVApp.NativeMethodInfoPtr_Resume_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVApp>.NativeClassPtr, 100666901);
			TVApp.NativeMethodInfoPtr_Lerp_Private_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVApp>.NativeClassPtr, 100666902);
			TVApp.NativeMethodInfoPtr_ActiveMinPass_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVApp>.NativeClassPtr, 100666903);
			TVApp.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVApp>.NativeClassPtr, 100666904);
			TVApp.NativeMethodInfoPtr_TryPause_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVApp>.NativeClassPtr, 100666905);
			TVApp.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVApp>.NativeClassPtr, 100666906);
			TVApp.NativeMethodInfoPtr_Method_Private_IEnumerator_Single_Single_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVApp>.NativeClassPtr, 100666907);
		}

		// Token: 0x17000B2C RID: 2860
		// (get) Token: 0x0600203B RID: 8251 RVA: 0x000D4D9C File Offset: 0x000D2F9C
		// (set) Token: 0x0600203C RID: 8252 RVA: 0x000D4DD8 File Offset: 0x000D2FD8
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35361, RefRangeEnd = 35362, XrefRangeStart = 35361, XrefRangeEnd = 35362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVApp.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 35362, RefRangeEnd = 35364, XrefRangeStart = 35362, XrefRangeEnd = 35364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVApp.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000B2D RID: 2861
		// (get) Token: 0x0600203D RID: 8253 RVA: 0x000D4E18 File Offset: 0x000D3018
		public unsafe bool IsPaused
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 108670, RefRangeEnd = 108677, XrefRangeStart = 108666, XrefRangeEnd = 108670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVApp.NativeMethodInfoPtr_get_IsPaused_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600203E RID: 8254 RVA: 0x000D4E54 File Offset: 0x000D3054
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 108689, RefRangeEnd = 108692, XrefRangeStart = 108677, XrefRangeEnd = 108689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TVApp.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600203F RID: 8255 RVA: 0x000D4E90 File Offset: 0x000D3090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108692, XrefRangeEnd = 108702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVApp.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002040 RID: 8256 RVA: 0x000D4EC4 File Offset: 0x000D30C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 108734, RefRangeEnd = 108736, XrefRangeStart = 108702, XrefRangeEnd = 108734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TVApp.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002041 RID: 8257 RVA: 0x000D4F00 File Offset: 0x000D3100
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 108760, RefRangeEnd = 108761, XrefRangeStart = 108736, XrefRangeEnd = 108760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TVApp.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002042 RID: 8258 RVA: 0x000D4F3C File Offset: 0x000D313C
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TVApp.NativeMethodInfoPtr_Resume_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002043 RID: 8259 RVA: 0x000D4F78 File Offset: 0x000D3178
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 108777, RefRangeEnd = 108779, XrefRangeStart = 108761, XrefRangeEnd = 108777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Lerp(float endScale, float endAlpha)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref endScale;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endAlpha;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVApp.NativeMethodInfoPtr_Lerp_Private_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002044 RID: 8260 RVA: 0x000D4FC4 File Offset: 0x000D31C4
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ActiveMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TVApp.NativeMethodInfoPtr_ActiveMinPass_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002045 RID: 8261 RVA: 0x000D5000 File Offset: 0x000D3200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108779, XrefRangeEnd = 108780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVApp.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002046 RID: 8262 RVA: 0x000D5044 File Offset: 0x000D3244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108780, XrefRangeEnd = 108782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void TryPause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TVApp.NativeMethodInfoPtr_TryPause_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002047 RID: 8263 RVA: 0x000D5080 File Offset: 0x000D3280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108782, XrefRangeEnd = 108783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TVApp() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TVApp>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVApp.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002048 RID: 8264 RVA: 0x000D50BC File Offset: 0x000D32BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108783, XrefRangeEnd = 108788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_Single_Single_PDM_0(float endScale, float endAlpha)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref endScale;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endAlpha;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVApp.NativeMethodInfoPtr_Method_Private_IEnumerator_Single_Single_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002049 RID: 8265 RVA: 0x00012294 File Offset: 0x00010494
		public TVApp(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000B1F RID: 2847
		// (get) Token: 0x0600204A RID: 8266 RVA: 0x000D5118 File Offset: 0x000D3318
		// (set) Token: 0x0600204B RID: 8267 RVA: 0x0001229D File Offset: 0x0001049D
		public unsafe static float SCALE_MIN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TVApp.NativeFieldInfoPtr_SCALE_MIN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TVApp.NativeFieldInfoPtr_SCALE_MIN, (void*)(&value));
			}
		}

		// Token: 0x17000B20 RID: 2848
		// (get) Token: 0x0600204C RID: 8268 RVA: 0x000D5134 File Offset: 0x000D3334
		// (set) Token: 0x0600204D RID: 8269 RVA: 0x000122AB File Offset: 0x000104AB
		public unsafe static float SCALE_MAX
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TVApp.NativeFieldInfoPtr_SCALE_MAX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TVApp.NativeFieldInfoPtr_SCALE_MAX, (void*)(&value));
			}
		}

		// Token: 0x17000B21 RID: 2849
		// (get) Token: 0x0600204E RID: 8270 RVA: 0x000D5150 File Offset: 0x000D3350
		// (set) Token: 0x0600204F RID: 8271 RVA: 0x000122B9 File Offset: 0x000104B9
		public unsafe static float LERP_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(TVApp.NativeFieldInfoPtr_LERP_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TVApp.NativeFieldInfoPtr_LERP_TIME, (void*)(&value));
			}
		}

		// Token: 0x17000B22 RID: 2850
		// (get) Token: 0x06002050 RID: 8272 RVA: 0x000D516C File Offset: 0x000D336C
		// (set) Token: 0x06002051 RID: 8273 RVA: 0x000122C7 File Offset: 0x000104C7
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B23 RID: 2851
		// (get) Token: 0x06002052 RID: 8274 RVA: 0x000D5194 File Offset: 0x000D3394
		// (set) Token: 0x06002053 RID: 8275 RVA: 0x000122E2 File Offset: 0x000104E2
		public unsafe bool CanClose
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.NativeFieldInfoPtr_CanClose);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.NativeFieldInfoPtr_CanClose)) = value;
			}
		}

		// Token: 0x17000B24 RID: 2852
		// (get) Token: 0x06002054 RID: 8276 RVA: 0x000D51BC File Offset: 0x000D33BC
		// (set) Token: 0x06002055 RID: 8277 RVA: 0x000122FD File Offset: 0x000104FD
		public unsafe string AppName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.NativeFieldInfoPtr_AppName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.NativeFieldInfoPtr_AppName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000B25 RID: 2853
		// (get) Token: 0x06002056 RID: 8278 RVA: 0x000D51E4 File Offset: 0x000D33E4
		// (set) Token: 0x06002057 RID: 8279 RVA: 0x0001231C File Offset: 0x0001051C
		public unsafe Sprite Icon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.NativeFieldInfoPtr_Icon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.NativeFieldInfoPtr_Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B26 RID: 2854
		// (get) Token: 0x06002058 RID: 8280 RVA: 0x000D5214 File Offset: 0x000D3414
		// (set) Token: 0x06002059 RID: 8281 RVA: 0x0001233B File Offset: 0x0001053B
		public unsafe bool Pauseable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.NativeFieldInfoPtr_Pauseable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.NativeFieldInfoPtr_Pauseable)) = value;
			}
		}

		// Token: 0x17000B27 RID: 2855
		// (get) Token: 0x0600205A RID: 8282 RVA: 0x000D523C File Offset: 0x000D343C
		// (set) Token: 0x0600205B RID: 8283 RVA: 0x00012356 File Offset: 0x00010556
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B28 RID: 2856
		// (get) Token: 0x0600205C RID: 8284 RVA: 0x000D526C File Offset: 0x000D346C
		// (set) Token: 0x0600205D RID: 8285 RVA: 0x00012375 File Offset: 0x00010575
		public unsafe TVApp PreviousScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.NativeFieldInfoPtr_PreviousScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TVApp>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.NativeFieldInfoPtr_PreviousScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B29 RID: 2857
		// (get) Token: 0x0600205E RID: 8286 RVA: 0x000D529C File Offset: 0x000D349C
		// (set) Token: 0x0600205F RID: 8287 RVA: 0x00012394 File Offset: 0x00010594
		public unsafe CanvasGroup CanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.NativeFieldInfoPtr_CanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.NativeFieldInfoPtr_CanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B2A RID: 2858
		// (get) Token: 0x06002060 RID: 8288 RVA: 0x000D52CC File Offset: 0x000D34CC
		// (set) Token: 0x06002061 RID: 8289 RVA: 0x000123B3 File Offset: 0x000105B3
		public unsafe TVPauseScreen PauseScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.NativeFieldInfoPtr_PauseScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TVPauseScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.NativeFieldInfoPtr_PauseScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B2B RID: 2859
		// (get) Token: 0x06002062 RID: 8290 RVA: 0x000D52FC File Offset: 0x000D34FC
		// (set) Token: 0x06002063 RID: 8291 RVA: 0x000123D2 File Offset: 0x000105D2
		public unsafe Coroutine lerpCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.NativeFieldInfoPtr_lerpCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.NativeFieldInfoPtr_lerpCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400155C RID: 5468
		private static readonly IntPtr NativeFieldInfoPtr_SCALE_MIN;

		// Token: 0x0400155D RID: 5469
		private static readonly IntPtr NativeFieldInfoPtr_SCALE_MAX;

		// Token: 0x0400155E RID: 5470
		private static readonly IntPtr NativeFieldInfoPtr_LERP_TIME;

		// Token: 0x0400155F RID: 5471
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04001560 RID: 5472
		private static readonly IntPtr NativeFieldInfoPtr_CanClose;

		// Token: 0x04001561 RID: 5473
		private static readonly IntPtr NativeFieldInfoPtr_AppName;

		// Token: 0x04001562 RID: 5474
		private static readonly IntPtr NativeFieldInfoPtr_Icon;

		// Token: 0x04001563 RID: 5475
		private static readonly IntPtr NativeFieldInfoPtr_Pauseable;

		// Token: 0x04001564 RID: 5476
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04001565 RID: 5477
		private static readonly IntPtr NativeFieldInfoPtr_PreviousScreen;

		// Token: 0x04001566 RID: 5478
		private static readonly IntPtr NativeFieldInfoPtr_CanvasGroup;

		// Token: 0x04001567 RID: 5479
		private static readonly IntPtr NativeFieldInfoPtr_PauseScreen;

		// Token: 0x04001568 RID: 5480
		private static readonly IntPtr NativeFieldInfoPtr_lerpCoroutine;

		// Token: 0x04001569 RID: 5481
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x0400156A RID: 5482
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x0400156B RID: 5483
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPaused_Public_get_Boolean_0;

		// Token: 0x0400156C RID: 5484
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x0400156D RID: 5485
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x0400156E RID: 5486
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Virtual_New_Void_0;

		// Token: 0x0400156F RID: 5487
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0;

		// Token: 0x04001570 RID: 5488
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Public_Virtual_New_Void_0;

		// Token: 0x04001571 RID: 5489
		private static readonly IntPtr NativeMethodInfoPtr_Lerp_Private_Void_Single_Single_0;

		// Token: 0x04001572 RID: 5490
		private static readonly IntPtr NativeMethodInfoPtr_ActiveMinPass_Protected_Virtual_New_Void_0;

		// Token: 0x04001573 RID: 5491
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04001574 RID: 5492
		private static readonly IntPtr NativeMethodInfoPtr_TryPause_Protected_Virtual_New_Void_0;

		// Token: 0x04001575 RID: 5493
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001576 RID: 5494
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_Single_Single_PDM_0;

		// Token: 0x020008B7 RID: 2231
		[ObfuscatedName("ScheduleOne.TV.TVApp+<<Lerp>g__Lerp|23_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600C30A RID: 49930 RVA: 0x002F9960 File Offset: 0x002F7B60
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique()
			{
				Il2CppClassPointerStore<TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TVApp>.NativeClassPtr, "<<Lerp>g__Lerp|23_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique>.NativeClassPtr);
				TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique>.NativeClassPtr, "<>1__state");
				TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique>.NativeClassPtr, "<>2__current");
				TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique>.NativeClassPtr, "<>4__this");
				TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeFieldInfoPtr_endScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique>.NativeClassPtr, "endScale");
				TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeFieldInfoPtr_endAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique>.NativeClassPtr, "endAlpha");
				TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeFieldInfoPtr__startScale_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique>.NativeClassPtr, "<startScale>5__2");
				TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeFieldInfoPtr__startAlpha_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique>.NativeClassPtr, "<startAlpha>5__3");
				TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeFieldInfoPtr__lerpTime_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique>.NativeClassPtr, "<lerpTime>5__4");
				TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeFieldInfoPtr__i_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique>.NativeClassPtr, "<i>5__5");
				TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique>.NativeClassPtr, 100666908);
				TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique>.NativeClassPtr, 100666909);
				TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique>.NativeClassPtr, 100666910);
				TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique>.NativeClassPtr, 100666911);
				TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique>.NativeClassPtr, 100666912);
				TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique>.NativeClassPtr, 100666913);
			}

			// Token: 0x0600C30B RID: 49931 RVA: 0x002F9AB8 File Offset: 0x002F7CB8
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C30C RID: 49932 RVA: 0x002F9B00 File Offset: 0x002F7D00
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C30D RID: 49933 RVA: 0x002F9B34 File Offset: 0x002F7D34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108624, XrefRangeEnd = 108661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003CEB RID: 15595
			// (get) Token: 0x0600C30E RID: 49934 RVA: 0x002F9B70 File Offset: 0x002F7D70
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C30F RID: 49935 RVA: 0x002F9BB0 File Offset: 0x002F7DB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108661, XrefRangeEnd = 108666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003CEC RID: 15596
			// (get) Token: 0x0600C310 RID: 49936 RVA: 0x002F9BE4 File Offset: 0x002F7DE4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C311 RID: 49937 RVA: 0x0005EE73 File Offset: 0x0005D073
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003CE2 RID: 15586
			// (get) Token: 0x0600C312 RID: 49938 RVA: 0x002F9C24 File Offset: 0x002F7E24
			// (set) Token: 0x0600C313 RID: 49939 RVA: 0x0005EE7C File Offset: 0x0005D07C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003CE3 RID: 15587
			// (get) Token: 0x0600C314 RID: 49940 RVA: 0x002F9C4C File Offset: 0x002F7E4C
			// (set) Token: 0x0600C315 RID: 49941 RVA: 0x0005EE97 File Offset: 0x0005D097
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CE4 RID: 15588
			// (get) Token: 0x0600C316 RID: 49942 RVA: 0x002F9C7C File Offset: 0x002F7E7C
			// (set) Token: 0x0600C317 RID: 49943 RVA: 0x0005EEB6 File Offset: 0x0005D0B6
			public unsafe TVApp __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TVApp>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003CE5 RID: 15589
			// (get) Token: 0x0600C318 RID: 49944 RVA: 0x002F9CAC File Offset: 0x002F7EAC
			// (set) Token: 0x0600C319 RID: 49945 RVA: 0x0005EED5 File Offset: 0x0005D0D5
			public unsafe float endScale
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeFieldInfoPtr_endScale);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeFieldInfoPtr_endScale)) = value;
				}
			}

			// Token: 0x17003CE6 RID: 15590
			// (get) Token: 0x0600C31A RID: 49946 RVA: 0x002F9CD4 File Offset: 0x002F7ED4
			// (set) Token: 0x0600C31B RID: 49947 RVA: 0x0005EEF0 File Offset: 0x0005D0F0
			public unsafe float endAlpha
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeFieldInfoPtr_endAlpha);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeFieldInfoPtr_endAlpha)) = value;
				}
			}

			// Token: 0x17003CE7 RID: 15591
			// (get) Token: 0x0600C31C RID: 49948 RVA: 0x002F9CFC File Offset: 0x002F7EFC
			// (set) Token: 0x0600C31D RID: 49949 RVA: 0x0005EF0B File Offset: 0x0005D10B
			public unsafe float _startScale_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeFieldInfoPtr__startScale_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeFieldInfoPtr__startScale_5__2)) = value;
				}
			}

			// Token: 0x17003CE8 RID: 15592
			// (get) Token: 0x0600C31E RID: 49950 RVA: 0x002F9D24 File Offset: 0x002F7F24
			// (set) Token: 0x0600C31F RID: 49951 RVA: 0x0005EF26 File Offset: 0x0005D126
			public unsafe float _startAlpha_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeFieldInfoPtr__startAlpha_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeFieldInfoPtr__startAlpha_5__3)) = value;
				}
			}

			// Token: 0x17003CE9 RID: 15593
			// (get) Token: 0x0600C320 RID: 49952 RVA: 0x002F9D4C File Offset: 0x002F7F4C
			// (set) Token: 0x0600C321 RID: 49953 RVA: 0x0005EF41 File Offset: 0x0005D141
			public unsafe float _lerpTime_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeFieldInfoPtr__lerpTime_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeFieldInfoPtr__lerpTime_5__4)) = value;
				}
			}

			// Token: 0x17003CEA RID: 15594
			// (get) Token: 0x0600C322 RID: 49954 RVA: 0x002F9D74 File Offset: 0x002F7F74
			// (set) Token: 0x0600C323 RID: 49955 RVA: 0x0005EF5C File Offset: 0x0005D15C
			public unsafe float _i_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeFieldInfoPtr__i_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TVApp.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTVSienSienObSiObUnique.NativeFieldInfoPtr__i_5__5)) = value;
				}
			}

			// Token: 0x0400844C RID: 33868
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400844D RID: 33869
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400844E RID: 33870
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400844F RID: 33871
			private static readonly IntPtr NativeFieldInfoPtr_endScale;

			// Token: 0x04008450 RID: 33872
			private static readonly IntPtr NativeFieldInfoPtr_endAlpha;

			// Token: 0x04008451 RID: 33873
			private static readonly IntPtr NativeFieldInfoPtr__startScale_5__2;

			// Token: 0x04008452 RID: 33874
			private static readonly IntPtr NativeFieldInfoPtr__startAlpha_5__3;

			// Token: 0x04008453 RID: 33875
			private static readonly IntPtr NativeFieldInfoPtr__lerpTime_5__4;

			// Token: 0x04008454 RID: 33876
			private static readonly IntPtr NativeFieldInfoPtr__i_5__5;

			// Token: 0x04008455 RID: 33877
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008456 RID: 33878
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008457 RID: 33879
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008458 RID: 33880
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008459 RID: 33881
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400845A RID: 33882
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
