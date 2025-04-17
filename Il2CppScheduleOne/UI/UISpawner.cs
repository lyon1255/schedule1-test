using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200066F RID: 1647
	public class UISpawner : MonoBehaviour
	{
		// Token: 0x060092F8 RID: 37624 RVA: 0x0025DCD4 File Offset: 0x0025BED4
		// Note: this type is marked as 'beforefieldinit'.
		static UISpawner()
		{
			Il2CppClassPointerStore<UISpawner>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "UISpawner");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UISpawner>.NativeClassPtr);
			UISpawner.NativeFieldInfoPtr_SpawnArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISpawner>.NativeClassPtr, "SpawnArea");
			UISpawner.NativeFieldInfoPtr_Prefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISpawner>.NativeClassPtr, "Prefabs");
			UISpawner.NativeFieldInfoPtr_MinInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISpawner>.NativeClassPtr, "MinInterval");
			UISpawner.NativeFieldInfoPtr_MaxInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISpawner>.NativeClassPtr, "MaxInterval");
			UISpawner.NativeFieldInfoPtr_SpawnRateMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISpawner>.NativeClassPtr, "SpawnRateMultiplier");
			UISpawner.NativeFieldInfoPtr_MinScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISpawner>.NativeClassPtr, "MinScale");
			UISpawner.NativeFieldInfoPtr_MaxScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISpawner>.NativeClassPtr, "MaxScale");
			UISpawner.NativeFieldInfoPtr_UniformScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISpawner>.NativeClassPtr, "UniformScale");
			UISpawner.NativeFieldInfoPtr_nextSpawnTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISpawner>.NativeClassPtr, "nextSpawnTime");
			UISpawner.NativeFieldInfoPtr_OnSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISpawner>.NativeClassPtr, "OnSpawn");
			UISpawner.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISpawner>.NativeClassPtr, 100681526);
			UISpawner.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISpawner>.NativeClassPtr, 100681527);
			UISpawner.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISpawner>.NativeClassPtr, 100681528);
		}

		// Token: 0x060092F9 RID: 37625 RVA: 0x0025DE08 File Offset: 0x0025C008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264844, XrefRangeEnd = 264846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISpawner.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060092FA RID: 37626 RVA: 0x0025DE3C File Offset: 0x0025C03C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264846, XrefRangeEnd = 264875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISpawner.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060092FB RID: 37627 RVA: 0x0025DE70 File Offset: 0x0025C070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264875, XrefRangeEnd = 264880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UISpawner() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UISpawner>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISpawner.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060092FC RID: 37628 RVA: 0x000472AB File Offset: 0x000454AB
		public UISpawner(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002D0C RID: 11532
		// (get) Token: 0x060092FD RID: 37629 RVA: 0x0025DEAC File Offset: 0x0025C0AC
		// (set) Token: 0x060092FE RID: 37630 RVA: 0x000472B4 File Offset: 0x000454B4
		public unsafe RectTransform SpawnArea
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_SpawnArea);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_SpawnArea), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D0D RID: 11533
		// (get) Token: 0x060092FF RID: 37631 RVA: 0x0025DEDC File Offset: 0x0025C0DC
		// (set) Token: 0x06009300 RID: 37632 RVA: 0x000472D3 File Offset: 0x000454D3
		public unsafe Il2CppReferenceArray<GameObject> Prefabs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_Prefabs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_Prefabs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D0E RID: 11534
		// (get) Token: 0x06009301 RID: 37633 RVA: 0x0025DF0C File Offset: 0x0025C10C
		// (set) Token: 0x06009302 RID: 37634 RVA: 0x000472F2 File Offset: 0x000454F2
		public unsafe float MinInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_MinInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_MinInterval)) = value;
			}
		}

		// Token: 0x17002D0F RID: 11535
		// (get) Token: 0x06009303 RID: 37635 RVA: 0x0025DF34 File Offset: 0x0025C134
		// (set) Token: 0x06009304 RID: 37636 RVA: 0x0004730D File Offset: 0x0004550D
		public unsafe float MaxInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_MaxInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_MaxInterval)) = value;
			}
		}

		// Token: 0x17002D10 RID: 11536
		// (get) Token: 0x06009305 RID: 37637 RVA: 0x0025DF5C File Offset: 0x0025C15C
		// (set) Token: 0x06009306 RID: 37638 RVA: 0x00047328 File Offset: 0x00045528
		public unsafe float SpawnRateMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_SpawnRateMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_SpawnRateMultiplier)) = value;
			}
		}

		// Token: 0x17002D11 RID: 11537
		// (get) Token: 0x06009307 RID: 37639 RVA: 0x0025DF84 File Offset: 0x0025C184
		// (set) Token: 0x06009308 RID: 37640 RVA: 0x00047343 File Offset: 0x00045543
		public unsafe Vector2 MinScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_MinScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_MinScale)) = value;
			}
		}

		// Token: 0x17002D12 RID: 11538
		// (get) Token: 0x06009309 RID: 37641 RVA: 0x0025DFAC File Offset: 0x0025C1AC
		// (set) Token: 0x0600930A RID: 37642 RVA: 0x0004735E File Offset: 0x0004555E
		public unsafe Vector2 MaxScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_MaxScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_MaxScale)) = value;
			}
		}

		// Token: 0x17002D13 RID: 11539
		// (get) Token: 0x0600930B RID: 37643 RVA: 0x0025DFD4 File Offset: 0x0025C1D4
		// (set) Token: 0x0600930C RID: 37644 RVA: 0x00047379 File Offset: 0x00045579
		public unsafe bool UniformScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_UniformScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_UniformScale)) = value;
			}
		}

		// Token: 0x17002D14 RID: 11540
		// (get) Token: 0x0600930D RID: 37645 RVA: 0x0025DFFC File Offset: 0x0025C1FC
		// (set) Token: 0x0600930E RID: 37646 RVA: 0x00047394 File Offset: 0x00045594
		public unsafe float nextSpawnTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_nextSpawnTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_nextSpawnTime)) = value;
			}
		}

		// Token: 0x17002D15 RID: 11541
		// (get) Token: 0x0600930F RID: 37647 RVA: 0x0025E024 File Offset: 0x0025C224
		// (set) Token: 0x06009310 RID: 37648 RVA: 0x000473AF File Offset: 0x000455AF
		public unsafe UnityEvent<GameObject> OnSpawn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_OnSpawn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_OnSpawn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400633E RID: 25406
		private static readonly IntPtr NativeFieldInfoPtr_SpawnArea;

		// Token: 0x0400633F RID: 25407
		private static readonly IntPtr NativeFieldInfoPtr_Prefabs;

		// Token: 0x04006340 RID: 25408
		private static readonly IntPtr NativeFieldInfoPtr_MinInterval;

		// Token: 0x04006341 RID: 25409
		private static readonly IntPtr NativeFieldInfoPtr_MaxInterval;

		// Token: 0x04006342 RID: 25410
		private static readonly IntPtr NativeFieldInfoPtr_SpawnRateMultiplier;

		// Token: 0x04006343 RID: 25411
		private static readonly IntPtr NativeFieldInfoPtr_MinScale;

		// Token: 0x04006344 RID: 25412
		private static readonly IntPtr NativeFieldInfoPtr_MaxScale;

		// Token: 0x04006345 RID: 25413
		private static readonly IntPtr NativeFieldInfoPtr_UniformScale;

		// Token: 0x04006346 RID: 25414
		private static readonly IntPtr NativeFieldInfoPtr_nextSpawnTime;

		// Token: 0x04006347 RID: 25415
		private static readonly IntPtr NativeFieldInfoPtr_OnSpawn;

		// Token: 0x04006348 RID: 25416
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04006349 RID: 25417
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400634A RID: 25418
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
